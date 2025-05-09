using Acessibilidade.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acessibilidade.DAL;

namespace Telalogin.view
{
    public partial class Agendamento : Form
    {
        private readonly int _idCadastro;
        public Agendamento(int idCadastro)
        {
            InitializeComponent();
            _idCadastro = idCadastro;
            CarregarPostos();
            CarregarAgendamentosUsuario();
        }

        private void CarregarPostos()
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT idPostos, nome, zona FROM Postos ORDER BY nome";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboPosto.DataSource = dt;
                    cboPosto.DisplayMember = "nome";
                    cboPosto.ValueMember = "idPostos";

                    cboPosto.Format += (sender, e) =>
                    {
                        if (e.ListItem != null)
                        {
                            DataRowView row = (DataRowView)e.ListItem;
                            e.Value = $"{row["nome"]} ({row["zona"]})";
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar postos: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.RegistrarErro(ex, _idCadastro.ToString(), nameof(CarregarPostos));
            }
        }

        private void CarregarAgendamentosUsuario()
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT a.IdAgendamentos, p.nome as Posto, 
                                    DATE_FORMAT(a.DataAgendamento, '%d/%m/%Y %H:%i') as DataFormatada,
                                    a.TipoServico, a.Status
                                    FROM Agendamentos a
                                    JOIN Postos p ON a.IdPostos = p.idPostos
                                    WHERE a.IdCadastro = @IdCadastro
                                    ORDER BY a.DataAgendamento DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdCadastro", _idCadastro);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAgendamentos.DataSource = dt;
                    dgvAgendamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar agendamentos: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.RegistrarErro(ex, _idCadastro.ToString(), nameof(CarregarAgendamentosUsuario));
            }
        }




        private void LimparCampos()
        {
            txtServico.Clear();
            txtObservacoes.Clear();
            dtpData.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
        }



        private void bordaredonda1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPosto.SelectedItem == null || string.IsNullOrWhiteSpace(txtServico.Text))
                {
                    MessageBox.Show("Por favor, selecione um posto e informe o serviço desejado.",
                                  "Dados Incompletos",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                DateTime dataAgendamento = dtpData.Value.Date + dtpHora.Value.TimeOfDay;

                if (dataAgendamento < DateTime.Now)
                {
                    MessageBox.Show("Não é possível agendar para datas/horários passados.",
                                  "Data Inválida",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Agendamentos 
                                     (IdCadastro, IdPostos, DataAgendamento, TipoServico, Observacoes)
                                     VALUES
                                     (@IdCadastro, @IdPostos, @DataAgendamento, @TipoServico, @Observacoes)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCadastro", _idCadastro); // Corrigido
                        cmd.Parameters.AddWithValue("@IdPostos", cboPosto.SelectedValue);
                        cmd.Parameters.AddWithValue("@DataAgendamento", dataAgendamento);
                        cmd.Parameters.AddWithValue("@TipoServico", txtServico.Text);
                        cmd.Parameters.AddWithValue("@Observacoes", txtObservacoes.Text);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Agendamento realizado com sucesso!", "Sucesso",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarAgendamentosUsuario();
                            LimparCampos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar agendamento: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.RegistrarErro(ex, _idCadastro.ToString(), nameof(btnAgendar_Click));
            }
        }




        private void CancelarAgendamento(int idAgendamento)
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Agendamentos SET Status = 'Cancelado' WHERE IdAgendamento = @IdAgendamento";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdAgendamento", idAgendamento);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Agendamento cancelado com sucesso.", "Sucesso",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarAgendamentosUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cancelar agendamento: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.RegistrarErro(ex, _idCadastro.ToString(), nameof(CancelarAgendamento));
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvAgendamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um agendamento para cancelar.", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idAgendamento = Convert.ToInt32(dgvAgendamentos.SelectedRows[0].Cells["IdAgendamento"].Value);

            if (MessageBox.Show("Deseja realmente cancelar este agendamento?", "Confirmar Cancelamento",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CancelarAgendamento(idAgendamento);
            }
        }

    }
}

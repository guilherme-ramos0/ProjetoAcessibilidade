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
using Acessibilidade.Models;

namespace Telalogin.view
{
    public partial class TelaPrincipal: Form
    {

        private readonly int idCadastro;
        public TelaPrincipal(int _idCadastro)
        {
            InitializeComponent();
            idCadastro = _idCadastro;
            CarregarDadosUsuario();
            CarregarAgendamentosRecentes();
            ConfigurarGridAgendamentos();
        }
        private void VerificarAgendamentos()
        {
            if (dgvAgendamentos.Rows.Count == 0)
            {
                lblStatusAgendamentos.Text = "Você não possui agendamentos.";
                lblStatusAgendamentos.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                lblStatusAgendamentos.Text = $"Você possui {dgvAgendamentos.Rows.Count} agendamento(s).";
                lblStatusAgendamentos.ForeColor = System.Drawing.Color.Green;
            }
        }



        private void CarregarDadosUsuario()
        {
            if (SessionManager.UsuarioLogado != null)
            {
                var usuario = SessionManager.UsuarioLogado;
                lblBemVindo.Text = $"Bem-vindo, {usuario.NomeCompleto}";
                lblCpf.Text = $"CPF: {FormatarCpf(usuario.Cpf)}";
            }
        }

        private void ConfigurarGridAgendamentos()
        {
            dgvAgendamentos.AutoGenerateColumns = false;
            dgvAgendamentos.Columns.Clear();

            // Configuração das colunas
            dgvAgendamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Posto",
                HeaderText = "Posto",
                Width = 150
            });

            dgvAgendamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataFormatada",
                HeaderText = "Data/Hora",
                Width = 120
            });

            dgvAgendamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TipoServico",
                HeaderText = "Serviço",
                Width = 150
            });

            

        }
        private void CarregarAgendamentosRecentes()
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT nome, dataAgendamento, tipoServico, observacoes, zona  FROM agendamentos
                            JOIN cadastro ON cadastro.idCadastro = agendamentos.idCadastro 
                            JOIN postos ON postos.idPostos = agendamentos.idPostos 
                            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCadastro", idCadastro);

                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);

                        // Criar lista de objetos anônimos para bind
                        var agendamentos = new List<dynamic>();
                        foreach (DataRow row in dt.Rows)
                        {
                            agendamentos.Add(new
                            {
                                Posto = row["nome"],
                                DataFormatada = Convert.ToDateTime(row["dataAgendamento"]).ToString("dd/MM/yyyy HH:mm"),
                                TipoServico = row["tipoServico"]
                            });
                        }

                        dgvAgendamentos.DataSource = agendamentos;
                    }
                }

                VerificarAgendamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar agendamentos: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.RegistrarErro(ex, idCadastro.ToString(), nameof(CarregarAgendamentosRecentes));
            }
        }



        private string FormatarCpf(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        private void MostrarDetalhesAgendamento(int idAgendamento)
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT a.*, p.nome as NomePosto, p.zona as ZonaPosto
                                    FROM Agendamentos a
                                    JOIN Postos p ON a.IdPostos = p.idPostos
                                    WHERE a.IdAgendamentos = @IdAgendamento";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdAgendamentos", idAgendamento);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string mensagem = $"Detalhes do Agendamento:\n\n" +
                                                 $"Posto: {reader["NomePosto"]} ({reader["ZonaPosto"]})\n" +
                                                 $"Data: {Convert.ToDateTime(reader["DataAgendamento"]):dd/MM/yyyy HH:mm}\n" +
                                                 $"Serviço: {reader["TipoServico"]}\n" +
                                                 $"Status: {reader["Status"]}\n" +
                                                 $"Observações: {reader["Observacoes"]}";

                                MessageBox.Show(mensagem, "Detalhes do Agendamento",
                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar detalhes: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.RegistrarErro(ex, idCadastro.ToString(), nameof(MostrarDetalhesAgendamento));
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            int idUsuarioLogado = SessionManager.UsuarioLogado.IdCadastro;

            // Crie o formulário passando o ID
            Agendamento formAgendamento = new Agendamento(idUsuarioLogado);

            // Mostre o formulário
            formAgendamento.Show();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            CarregarAgendamentosRecentes();
        }

        private void dgvAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

using Acessibilidade.Controllers;
using Acessibilidade.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telalogin.view
{
    public partial class TelaCadastro : Form
    {
        private ZonaController zonaController;
        private CadastroController cadastroController;
        public TelaCadastro()
        {
            InitializeComponent();
            zonaController = new ZonaController();
            cadastroController = new CadastroController();
            CarregarZonas();
        }

        private void CarregarZonas()
        {
            try
            {
                cmbZona.DataSource = zonaController.ListarTodos();
                cmbZona.DisplayMember = "Nome";
                cmbZona.ValueMember = "IdZonas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar zonas: {ex.Message}", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            // Aplicando placeholders
            PlaceholderHelper.AddPlaceholder(txtNomeCompleto, "Nome completo");
            PlaceholderHelper.AddPlaceholder(txtCpf, "000.000.000-00"); // ou "Digite seu CPF"
            PlaceholderHelper.AddPlaceholder(txtTelefone, "(11) 000-0000");
            // Configuração especial para os campos de senha
            txtSenha.Text = "Senha";
            txtSenha.ForeColor = SystemColors.GrayText;
            txtSenha.UseSystemPasswordChar = false;

            txtConfirmarSenha.Text = "Confirmar senha";
            txtConfirmarSenha.ForeColor = SystemColors.GrayText;
            txtConfirmarSenha.UseSystemPasswordChar = false;

            // Configura o CheckBox
            chkMostrarSenha.CheckedChanged += new EventHandler(ChkMostrarSenha_CheckedChanged);
        }
        private void ChkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se o texto atual é o placeholder
            bool isPlaceholderSenha = txtSenha.Text == "Senha";
            bool isPlaceholderConfirmar = txtConfirmarSenha.Text == "Confirmar senha";

            // Aplica apenas se não for placeholder
            if (!isPlaceholderSenha)
            {
                txtSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
            }

            if (!isPlaceholderConfirmar)
            {
                txtConfirmarSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
            }
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
                txtSenha.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.UseSystemPasswordChar = false;
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = SystemColors.GrayText;
            }
        }

        

        private void txtConfirmarSenha_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text == "Confirmar senha")
            {
                txtConfirmarSenha.Text = "";
                txtConfirmarSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
                txtConfirmarSenha.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmarSenha.Text))
            {
                txtConfirmarSenha.UseSystemPasswordChar = false;
                txtConfirmarSenha.Text = "Confirmar senha";
                txtConfirmarSenha.ForeColor = SystemColors.GrayText;
            }
        }


        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            // Se for placeholder, não faz nada
            if (txtSenha.Text == "Senha" || txtConfirmarSenha.Text == "Confirmar senha")
                return;

            txtSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
            txtConfirmarSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
        }

        private void botaoBordaArredondada2_Click(object sender, EventArgs e)
        {
            Login loginUsuario = new Login();
            loginUsuario.Show();
        }

        private void botaoBordaArredondada1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {

                // Obter a zona selecionada
                var zonaSelecionada = cmbZona.SelectedItem as Zona;

                if (zonaSelecionada == null)
                {
                    MessageBox.Show("Selecione uma zona válida!", "Atenção",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Converter a data de nascimento
                DateTime dataNasc;
                if (!DateTime.TryParseExact(dtpNascimento.Text, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNasc))
                {
                    MessageBox.Show("Data de nascimento inválida!", "Atenção",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpNascimento.Focus();
                    return;
                }

                var novoUsuario = new Cadastro
                {
                    NomeCompleto = txtNomeCompleto.Text.Trim(),
                    DataNascimento = dataNasc,
                    Telefone = txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""),
                    Cpf = txtCpf.Text.Replace(".", "").Replace("-", ""),
                    Senha = txtSenha.Text,
                    Zonas_idZonas = zonaSelecionada.IdZonas
                };

                if (cadastroController.CadastrarUsuario(novoUsuario))
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TelaPrincipal principal = new TelaPrincipal(novoUsuario.IdCadastro);
                    principal.Show();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário.", "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro durante o cadastro: {ex.Message}", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNomeCompleto.Focus();
        }

        private bool ValidarCampos()
        {
            // Validação do nome
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("O nome completo é obrigatório!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCompleto.Focus();
                return false;
            }

            // Validação da data de nascimento
            if (!dtpNascimento.MaskCompleted)
            {
                MessageBox.Show("Informe a data de nascimento completa!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNascimento.Focus();
                return false;
            }

            DateTime dataNasc;
            if (!DateTime.TryParseExact(dtpNascimento.Text, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNasc))
            {
                MessageBox.Show("Data de nascimento inválida!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNascimento.Focus();
                return false;
            }

            // Verificar se a data é futura
            if (dataNasc > DateTime.Today)
            {
                MessageBox.Show("Data de nascimento não pode ser futura!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNascimento.Focus();
                return false;
            }

            // Verificar idade mínima (5 anos)
            if (dataNasc > DateTime.Today.AddYears(-5))
            {
                MessageBox.Show("O usuário deve ter pelo menos 5 anos de idade!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNascimento.Focus();
                return false;
            }

            // Validação do telefone
            if (!txtTelefone.MaskCompleted)
            {
                MessageBox.Show("Telefone inválido! Informe o número completo.", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefone.Focus();
                return false;
            }

            // Validação do CPF
            if (!txtCpf.MaskCompleted)
            {
                MessageBox.Show("CPF inválido! Informe o número completo.", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return false;
            }

            // Validação da senha
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("A senha é obrigatória!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }

            // Confirmação de senha
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarSenha.Focus();
                return false;
            }

            return true;
        }

        private void cmbZona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


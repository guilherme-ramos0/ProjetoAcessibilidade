using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telalogin.view
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            // Aplicando placeholders
            PlaceholderHelper.AddPlaceholder(txtNomeCompleto, "Nome completo");
            PlaceholderHelper.AddPlaceholder(mtxtCpf, "000.000.000-00"); // ou "Digite seu CPF"
            PlaceholderHelper.AddPlaceholder(txtEmail, "email@exemplo.com");
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
    }
}

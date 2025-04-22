using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLoginCadastro
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private string HashSenha(string senha) // Função para gerar o hash da senha
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                return Convert.ToBase64String(hashBytes);
            }
        }
        private void txtNomeCompleto_Enter(object sender, EventArgs e)  
        {
            if (txtNomeCompleto.Text == "Nome Completo")
            {
                txtNomeCompleto.Text = "";
                txtNomeCompleto.ForeColor = Color.Black;
            }
        }
        private void txtNomeCompleto_Leave(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text == "")
            {
                txtNomeCompleto.Text = "Nome Completo";
                txtNomeCompleto.ForeColor = Color.Gray;
            }
        }
        private void txtCPF_Enter(object sender, EventArgs e)
        {
            if (txtCPF.Text == "CPF")
            {
                txtCPF.Text = "";
                txtCPF.ForeColor = Color.Black;
            }
        }
        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                txtCPF.Text = "CPF";
                txtCPF.ForeColor = Color.Gray;
            }
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gray;
            }

        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Senha") 
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") 
            {
                txtPassword.Text = "Senha";
                txtPassword.ForeColor = Color.Gray;
            }
        }
        private void txtConfirmarPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarPassword.Text == "Confirmar Senha") 
            {
                txtConfirmarPassword.Text = "";
                txtConfirmarPassword.ForeColor = Color.Black;
            }
        }
        private void txtConfirmarPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarPassword.Text == "") 
            {
                txtConfirmarPassword.Text = "Confirmar senha";
                txtConfirmarPassword.ForeColor = Color.Gray;
            }
        }
        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            txtNomeCompleto.ForeColor = Color.Gray;
            txtCPF.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
            txtConfirmarPassword.ForeColor = Color.Gray;
        }

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telalogin
{
    public partial class loginUsuario: Form
    {
        public loginUsuario()
        {
            InitializeComponent();
        }

        private string HashSenha(string senha)
        {
            using (SHA256 sha256 = sha256.Create())
            { 
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (cpf.Contains(",")) || senha.Contains(","))
            {
                MessageBox.Show("Os campos não podem conter vírgulas.");
                return;
            }
        }
    }
}

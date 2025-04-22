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

namespace Telalogin
{
    public partial class loginUsuario : Form
    {
        public loginUsuario()
        {
            InitializeComponent();
        }

        private string HashSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cpf = txtBoxCpf.Text;
            string senha = txtBoxSenha.Text;

            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (cpf.Contains(",") || senha.Contains(","))
            {
                MessageBox.Show("Os campos não podem conter vírgulas.");
                return;
            }

            string caminho = "usuarios.txt";

            if (!File.Exists(caminho))
            {
                MessageBox.Show("Arquivo de usuários não encontrado.");
                return;
            }

            bool loginValido = false;
            foreach (var Linha in File.ReadLines(caminho))
            {
                var dados = Linha.Split(',');
                string senhaHash = HashSenha(senha);
                if (dados[0] == cpf && dados[1] == senhaHash)
                {
                    loginValido = true;
                    break;
                }
            }

            if (loginValido)
            {
                MessageBox.Show("Login bem-sucedido!");
            }
            else
            {
                MessageBox.Show("CPF ou senha inválidos.");
            }
        }

        /*public void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastro = new CadastroUsuario();
            cadastro.Show();
            this.Hide();
        }*/
    }
}

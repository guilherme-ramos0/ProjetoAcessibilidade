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
            //InitializeComponent();
        }
        // Função para gerar o hash da senha

        private string HashSenha(string senha)

        {

            using (SHA256 sha256 = SHA256.Create())

            {

                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));

                return Convert.ToBase64String(hashBytes);

            }

        }

        // Função para cadastrar um novo usuário

        public void btnCadastrar_Click(object sender, EventArgs e)

        {
            string nomeCompleto = txtNomeCompleto.Text;

            string cpf = txtCPF.Text;

            string email = txtEmail.Text;

            string senha = txtSenha.Text;

            string confirmarSenha = txtConfirmarSenha.Text;

            // Verifica se todos os campos estão preenchidos


            if (string.IsNullOrWhiteSpace(nomeCompleto) ||

            string.IsNullOrWhiteSpace(cpf) ||

            string.IsNullOrWhiteSpace(email) ||

            string.IsNullOrWhiteSpace(senha) ||

            string.IsNullOrWhiteSpace(confirmarSenha))

            {
                MessageBox.Show("Por favor, preencha todos os campos.");

                return;
            }
            // Verifica se as senhas coincidem


            if (senha != confirmarSenha)

            {

                MessageBox.Show("As senhas não coincidem.");

                return;
            }
            // Verifica se os campos contêm caracteres especiais não permitidos

            //if (nomeCompleto.Contains(",") || cpf.Contains(",") || email.Contains(","))

            {

                MessageBox.Show("Os campos não podem conter vírgulas.");

                return;

            }

            string caminho = "usuarios.txt"; // Caminho do arquivo de usuários
                                             // Verifica se o arquivo existe, senão cria

            if (!File.Exists(caminho))

            {

                File.Create(caminho).Close();
            }
            // Verifica se o CPF ou e-mail já estão cadastrados

            foreach (var linha in File.ReadLines(caminho))

            {
                var dados = linha.Split(',');
                // Verifica se o CPF ou o e-mail já existem no sistema

                //if (dados[2] == cpf || dados[3] == email)

                {
                    MessageBox.Show("CPF ou e-mail já cadastrados!");

                    return;
                }

            }
            // Gera o hash da senha

            //string senhaHash = HashSenha(senha);
            // Adiciona o novo usuário ao arquivo

            using (StreamWriter writer = new StreamWriter(caminho, true))

            {

                //writer.WriteLine($"{nomeCompleto},{cpf},{email},{senhaHash}");

            }
            MessageBox.Show("Cadastro realizado com sucesso!");

            this.Hide(); // Fecha o formulário de cadastro e volta ao login
        }
        // Função para voltar ao formulário de login

        private void btnVoltar_Click(object sender, EventArgs e)

        {

            this.Hide(); // Fecha o formulário de cadastro

        }

    }

}


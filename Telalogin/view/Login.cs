using Acessibilidade.Controllers;
using Acessibilidade.Models;
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
    public partial class Login : Form
    {
        private readonly LoginController _loginController;
        public Login()
        {
            InitializeComponent();
            Logger.RegistrarInfo("Aplicação iniciada", null, nameof(Login));
            _loginController = new LoginController();
        }

        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string cpf = mskCpf.Text.Replace(".", "").Replace("-", "").Trim();

            try
            {
                if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
                {
                    Logger.RegistrarAviso($"CPF inválido fornecido: {mskCpf.Text}", cpf, nameof(btnlogin_Click));
                    MessageBox.Show("CPF inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var usuarioAutenticado = _loginController.ValidarLogin(cpf, txtSenha.Text);

                if (usuarioAutenticado != null)
                {
                    // Login autorizado - mostra mensagem de sucesso
                    MessageBox.Show("Login autorizado com sucesso!",
                                  "Bem-vindo",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                    SessionManager.UsuarioLogado = usuarioAutenticado;
                    int idCadastro = SessionManager.UsuarioLogado.IdCadastro;

                    // Abre o formulário principal
                    TelaPrincipal formPrincipal = new TelaPrincipal(idCadastro);
                    formPrincipal.Show();
                }
                else
                {
                    Logger.RegistrarAviso("Tentativa de login falhou - Credenciais inválidas", cpf, nameof(btnlogin_Click));
                    MessageBox.Show("CPF ou senha incorretos", "Erro de Login",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logger.RegistrarErro(ex, cpf, nameof(btnlogin_Click));
                MessageBox.Show($"Falha técnica ao realizar login. Detalhes foram registrados.\n\nCódigo: {Guid.NewGuid()}",
                              "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        

        
        // Validação adicional enquanto digita o CPF
        private void mskCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle (backspace, delete, etc)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        } 
       


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        
    }
}

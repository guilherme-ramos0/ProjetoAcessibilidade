using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acessibilidade.Controllers;

namespace Telalogin.view
{
    public partial class Login: Form
    {
        private CadastroController cadastroController;


        public Login()
        {
            InitializeComponent();
            cadastroController = new CadastroController();

            mskCpf.ValidatingType = typeof(string);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Remover formatação do CPF
            string cpf = mskCpf.Text.Replace(".", "").Replace("-", "").Trim();
            string senha = txtSenha.Text;

            // Validação básica
            if (!mskCpf.MaskCompleted || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("CPF completo e senha são obrigatórios!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar estrutura do CPF (opcional)
            if (!cadastroController.ValidarCPF(cpf))
            {
                MessageBox.Show("CPF inválido!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCpf.Focus();
                return;
            }

            if (cadastroController.ValidarLogin(cpf, senha))
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new TelaPrincipal().Show();
            }
            else
            {
                MessageBox.Show("CPF ou senha incorretos!", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

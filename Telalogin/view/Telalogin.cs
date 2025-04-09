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
using Telalogin.view;

namespace Telalogin
{
    public partial class Telalogin : Form
    {

        private string HashSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                return Convert.ToBase64String(hashBytes);
            }
        }

        public Telalogin()
        {
            InitializeComponent();
            boxCpf.Text = "Digite seu CPF";
            boxCpf.ForeColor = Color.Gray;
            boxSenha.Text = "Digite sua senha";
            boxSenha.ForeColor = Color.Gray;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxCpf_Enter(object sender, EventArgs e)
        {
            if(boxCpf.Text == "Digite seu CPF")
            {
                boxCpf.Text = "";
                boxCpf.ForeColor = Color.Black;
            }
        }

        private void boxCpf_Leave(object sender, EventArgs e)
        {
            if (boxCpf.Text == "")
            {
                boxCpf.Text = "Digite seu CPF";
                boxCpf.ForeColor = Color.Gray;
            }
        }

        private void boxSenha_Enter(object sender, EventArgs e)
        {
            if (boxSenha.Text == "Digite sua senha")
            {
                boxSenha.Text = "";
                boxSenha.ForeColor = Color.Black;
            }
        }

        private void boxSenha_Leave(object sender, EventArgs e)
        {
            if (boxSenha.Text == "")
            {
                boxSenha.Text = "Digite sua senha";
                boxSenha.ForeColor = Color.Gray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
        }

        private void boxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    
    }
}

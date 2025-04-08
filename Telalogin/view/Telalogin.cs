using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telalogin
{
    public partial class Telalogin : Form
    {
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
    }
}

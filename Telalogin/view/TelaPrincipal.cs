using Acessibilidade.Utils;
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
    public partial class TelaPrincipal: Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            TelaMarcarTerapia pag1 = new TelaMarcarTerapia();
            pag1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idUsuarioLogado = SessionManager.UsuarioLogado.IdCadastro;

            // Crie o formulário passando o ID
            Agendamento formAgendamento = new Agendamento(idUsuarioLogado);

            // Mostre o formulário
            formAgendamento.ShowDialog();
        }
    }
}

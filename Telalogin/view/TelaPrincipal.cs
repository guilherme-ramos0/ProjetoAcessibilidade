using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAcessibilidade.view;

namespace Telalogin.view
{
    public partial class TelaPrincipal: Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgendarCons_Click(object sender, EventArgs e)
        {
            AgendarConsulta agendarConsulta = new AgendarConsulta();
            agendarConsulta.Show();
            this.Close();
        }
    }
}

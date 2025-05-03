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
    public partial class ConsultasAgendadas : Form
    {
        public ConsultasAgendadas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.RowHeadersVisible = false; // Oculta números das linhas
            dataGridView1.BackgroundColor = Color.White; // Cor de fundo
        }
    }
}

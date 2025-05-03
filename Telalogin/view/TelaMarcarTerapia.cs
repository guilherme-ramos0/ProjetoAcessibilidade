using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Telalogin.view
{
    public partial class TelaMarcarTerapia : Form
    {
        
        public TelaMarcarTerapia()
        {
            InitializeComponent();
        }



      
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            TableLayoutPanel panel = (TableLayoutPanel)sender;

            // Configurações da caneta (cor e largura das linhas)
            using (Pen linePen = new Pen(Color.Blue, 1)) // Cor única: Azul
            {
                // Configurações da caneta para a BORDA EXTERNA (mais grossa)
                using (Pen borderPen = new Pen(Color.Blue, 5)) // Espessura 3 (borda externa)
                {
                    // Desenha a borda externa (mais grossa)
                    e.Graphics.DrawRectangle(borderPen, 0, 0, panel.Width - 1, panel.Height - 1);
                }
                // Desenha linhas horizontais (entre linhas)
                int y = 0;
                for (int row = 0; row < panel.RowCount - 1; row++) // -1 para evitar linha extra no final
                {
                    y += panel.GetRowHeights()[row];
                    e.Graphics.DrawLine(linePen, 0, y, panel.Width, y);
                }

                // Desenha linhas verticais (entre colunas)
                int x = 0;
                for (int col = 0; col < panel.ColumnCount - 1; col++) // -1 para evitar linha extra no final
                {
                    x += panel.GetColumnWidths()[col];
                    e.Graphics.DrawLine(linePen, x, 0, x, panel.Height);
                }
            }
            

        }

        private void TelaMarcarTerapia_Load(object sender, EventArgs e)
        {
            
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class PedidoMedico : Form
    {
        public PedidoMedico()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            // Configurações da caneta (cor e largura da borda)
            using (Pen pen = new Pen(Color.Black, 1))
            {
                TableLayoutPanel panel = (TableLayoutPanel)sender;
                Rectangle rect = panel.ClientRectangle;

                // Desenha a borda externa
                e.Graphics.DrawRectangle(pen, rect);

                // Desenha bordas internas (linhas entre células)
                // Linhas horizontais
                int y = 0;
                foreach (RowStyle style in panel.RowStyles)
                {
                    y += (int)style.Height;
                    e.Graphics.DrawLine(pen, 0, y, panel.Width, y);
                }

                // Linhas verticais
                int x = 0;
                foreach (ColumnStyle style in panel.ColumnStyles)
                {
                    x += (int)style.Width;
                    e.Graphics.DrawLine(pen, x, 0, x, panel.Height);
                }
            }
        }
    }
}

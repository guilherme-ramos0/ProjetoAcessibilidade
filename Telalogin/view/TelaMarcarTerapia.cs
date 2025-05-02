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
    public partial class TelaMarcarTerapia : Form
    {
        // Declaração do menu de contexto e Label selecionado
        private ContextMenuStrip copyMenu;
        private Label selectedLabel;
        public TelaMarcarTerapia()
        {
            InitializeComponent();
            InitializeCopyMenu(); // Configura o menu de contexto
            ConfigureLabels();    // Configura os Labels existentes
        }

        private void InitializeCopyMenu()
        {
            // Cria o menu de contexto
            copyMenu = new ContextMenuStrip();

            // Adiciona a opção "Copiar"
            ToolStripMenuItem copyItem = new ToolStripMenuItem("Copiar");
            copyItem.Click += (sender, e) => CopySelectedLabelText();
            copyMenu.Items.Add(copyItem);
        }

        private void ConfigureLabels()
        {
            // Configura os Labels existentes no TableLayoutPanel
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label label)
                {
                    label.ContextMenuStrip = copyMenu;
                    label.MouseDown += Label_MouseDown;
                    label.MouseUp += Label_MouseUp;
                }
            }

            // Habilita atalhos de teclado (Ctrl+C)
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }

        // Evento de MouseDown para selecionar o Label
        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            selectedLabel = (Label)sender;
            selectedLabel.BackColor = Color.LightBlue; // Destaque visual
        }

        // Evento de MouseUp para remover o destaque
        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            Timer timer = new Timer { Interval = 200 }; // Remove o destaque após 200ms
            timer.Tick += (s, ev) =>
            {
                selectedLabel.BackColor = Color.Transparent;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        // Copia o texto do Label selecionado
        private void CopySelectedLabelText()
        {
            if (selectedLabel != null && !string.IsNullOrEmpty(selectedLabel.Text))
            {
                Clipboard.SetText(selectedLabel.Text);
                MessageBox.Show("Texto copiado: " + selectedLabel.Text);
            }
        }

        // Atalho de teclado (Ctrl+C)
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                CopySelectedLabelText();
                e.Handled = true;
            }
        }


        private void ConfigureLabel(Label label)
        {
            // Adiciona o menu de contexto
            label.ContextMenuStrip = copyMenu;

            // Configura os eventos de mouse
            label.MouseDown += Label_MouseDown;
            label.MouseUp += Label_MouseUp;

            // Permite que o Label receba foco (para Ctrl+C)
            label.TabStop = true;
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
            // Configura o menu de contexto
            copyMenu = new ContextMenuStrip();
            copyMenu.Items.Add("Copiar").Click += (s, ev) => CopySelectedLabelText();

            // Configura os Labels existentes
            foreach (Control control in tableLayoutPanel3.Controls.OfType<Label>())
            {
                ConfigureLabel((Label)control);
            }

            // Habilita o atalho Ctrl+C
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }

        private void AddLabelToPanel(string text, int column, int row)
        {
            Label newLabel = new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Configura o novo Label
            newLabel.ContextMenuStrip = copyMenu;
            newLabel.MouseDown += Label_MouseDown;
            newLabel.MouseUp += Label_MouseUp;

            tableLayoutPanel1.Controls.Add(newLabel, column, row);
        }   
    }
}

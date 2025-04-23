using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class Rounde : Panel
{
    // Raio dos cantos arredondados (ajuste conforme necessário)
    public int CornerRadius { get; set; } = 30;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Criar um caminho gráfico para bordas arredondadas
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90); // Canto superior esquerdo
            path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90); // Canto superior direito
            path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90); // Canto inferior direito
            path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90); // Canto inferior esquerdo
            path.CloseFigure();

            // Aplicar a região ao controle
            Region = new Region(path);

        }
    }

    // Atualizar a região quando o controle for redimensionado
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Invalidate();
    }
}
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class BotaoBordaArredondada : Button
{
    // Raio dos cantos (quanto maior, mais arredondado)
    public int CornerRadius { get; set; } = 20;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Rectangle rect = new Rectangle(0, 0, Width, Height);
        GraphicsPath path = GetRoundedRectPath(rect, CornerRadius);

        this.Region = new Region(path);

        // Opcional: desenha borda personalizada
        using (Pen pen = new Pen(this.FlatAppearance.BorderColor, 1))
        {
            e.Graphics.DrawPath(pen, path);
        }
    }

    private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);

        path.CloseFigure();
        return path;
    }
}
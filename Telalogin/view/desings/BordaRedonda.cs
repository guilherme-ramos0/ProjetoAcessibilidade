using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class Bordaredonda : Panel
{
    public int CornerRadius { get; set; } = 80;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90); // Canto superior esquerdo
            path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90); // Canto superior direito
            path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90); // Canto inferior direito
            path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90); // Canto inferior esquerdo
            path.CloseAllFigures();

            this.Region = new Region(path);

        }
    }
}
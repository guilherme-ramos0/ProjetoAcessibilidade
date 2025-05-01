using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class BorderedTableLayoutPanel : TableLayoutPanel
{
    private Dictionary<int, Color> _rowColors = new Dictionary<int, Color>();
    private Dictionary<int, Color> _columnColors = new Dictionary<int, Color>();

    public BorderedTableLayoutPanel()
    {
        this.DoubleBuffered = true; // Reduz flickering
        this.CellBorderStyle = TableLayoutPanelCellBorderStyle.None; // Remove bordas padrão
    }

    public void SetRowColor(int rowIndex, Color color)
    {
        _rowColors[rowIndex] = color;
        this.Invalidate();
    }

    public void SetColumnColor(int columnIndex, Color color)
    {
        _columnColors[columnIndex] = color;
        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawBorders(e.Graphics);
    }

    private void DrawBorders(Graphics g)
    {
        // Borda externa
        using (Pen borderPen = new Pen(Color.Blue, 5))
        {
            g.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
        }

        // Linhas horizontais
        int y = 0;
        int[] rowHeights = this.GetRowHeights();
        for (int row = 0; row < this.RowCount; row++)
        {
            Color lineColor = _rowColors.ContainsKey(row) ? _rowColors[row] : Color.Blue;
            using (Pen rowPen = new Pen(lineColor, 2))
            {
                y += rowHeights[row];
                g.DrawLine(rowPen, 0, y, this.Width, y);
            }
        }

        // Linhas verticais
        int x = 0;
        int[] colWidths = this.GetColumnWidths();
        for (int col = 0; col < this.ColumnCount; col++)
        {
            Color lineColor = _columnColors.ContainsKey(col) ? _columnColors[col] : Color.Blue;
            using (Pen colPen = new Pen(lineColor, 2))
            {
                x += colWidths[col];
                g.DrawLine(colPen, x, 0, x, this.Height);
            }
        }
    }
}
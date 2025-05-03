using System;
using System.Drawing;
using System.Windows.Forms;

public class TransparentTextBox : TextBox
{
    public TransparentTextBox()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        this.BackColor = Color.Transparent;
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        // Não desenha o fundo padrão (deixa transparente)
        base.OnPaintBackground(e);
    }
}
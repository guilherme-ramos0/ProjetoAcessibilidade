using System;
using System.Drawing;
using System.Windows.Forms;

public static class PlaceholderHelper
{
    public static void AddPlaceholder(TextBox textBox, string placeholderText)
    {
        // Configura o texto do placeholder
        textBox.Text = placeholderText;
        textBox.ForeColor = SystemColors.GrayText;

        // Adiciona os eventos
        textBox.Enter += (sender, e) => RemovePlaceholder(textBox, placeholderText);
        textBox.Leave += (sender, e) => SetPlaceholder(textBox, placeholderText);
    }

    public static void AddPlaceholder(MaskedTextBox maskedTextBox, string placeholderText)
    {
        // Configura o texto do placeholder
        maskedTextBox.Text = "";
        maskedTextBox.PromptChar = ' '; // Remove o caractere de prompt padrão
        maskedTextBox.ForeColor = SystemColors.GrayText;
        maskedTextBox.Text = placeholderText;

        // Adiciona os eventos
        maskedTextBox.Enter += (sender, e) => RemovePlaceholder(maskedTextBox, placeholderText);
        maskedTextBox.Leave += (sender, e) => SetPlaceholder(maskedTextBox, placeholderText);
    }

    private static void RemovePlaceholder(TextBoxBase control, string placeholderText)
    {
        if (control.Text == placeholderText)
        {
            control.Text = "";
            control.ForeColor = SystemColors.WindowText;

            if (control is MaskedTextBox maskedTextBox)
            {
                maskedTextBox.PromptChar = '_'; // Restaura o caractere de prompt se necessário
            }
        }
    }

    private static void SetPlaceholder(TextBoxBase control, string placeholderText)
    {
        if (string.IsNullOrWhiteSpace(control.Text))
        {
            control.Text = placeholderText;
            control.ForeColor = SystemColors.GrayText;

            if (control is MaskedTextBox maskedTextBox)
            {
                maskedTextBox.PromptChar = ' '; // Remove o caractere de prompt para o placeholder
            }
        }
    }
}
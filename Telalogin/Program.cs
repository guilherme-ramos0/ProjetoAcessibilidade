//using ProjetoAcessibilidade.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telalogin.view;

namespace Telalogin
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cria e mostra o formulário de login
            using (Login loginForm = new Login())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Se o login foi bem-sucedido, mostra o principal
                    Application.Run(new TelaPrincipal());
                }
                else
                {
                    // Se o login foi cancelado, fecha a aplicação
                    MessageBox.Show("Operação invalida, repita o login", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

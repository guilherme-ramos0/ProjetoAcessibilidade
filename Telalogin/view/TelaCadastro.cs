using System;
using System.Windows.Forms;

namespace SistemaLoginCadastro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Botão para ver a agenda de consultas
        private void btnAgendaConsultas_Click(object sender, EventArgs e)
        {
            // Cria uma instância da tela de agenda de consultas
            AgendaConsultasForm agendaForm = new AgendaConsultasForm();
            agendaForm.Show();
            this.Hide();  // Fecha o formulário principal
        }

        // Botão para ver os medicamentos
        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            // Cria uma instância da tela de medicamentos
            MedicamentosForm medicamentosForm = new MedicamentosForm();
            medicamentosForm.Show();
            this.Hide();  // Fecha o formulário principal
        }

        // Botão para agendar uma nova consulta
        private void btnAgendarConsulta_Click(object sender, EventArgs e)
        {
            // Cria uma instância da tela de agendamento de consulta
            AgendarConsultaForm agendarForm = new AgendarConsultaForm();
            agendarForm.Show();
            this.Hide();  // Fecha o formulário principal
        }

        // Botão para acessar consultas, prescrições e atestados
        private void btnConsultasPrescricoes_Click(object sender, EventArgs e)
        {
            // Cria uma instância da tela de consultas, prescrições e atestados
            ConsultasPrescricoesForm consultasForm = new ConsultasPrescricoesForm();
            consultasForm.Show();
            this.Hide();  // Fecha o formulário principal
        }

        // Botão para acessar pedidos médicos
        private void btnPedidosMedicos_Click(object sender, EventArgs e)
        {
            // Cria uma instância da tela de pedidos médicos
            PedidosMedicosForm pedidosForm = new PedidosMedicosForm();
            pedidosForm.Show();
            this.Hide();  // Fecha o formulário principal
        }

        // Botão para voltar ao início (login)
        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            // Cria uma instância da tela de login e volta para ela
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();  // Fecha o formulário atual (MainForm)
        }
    }
}
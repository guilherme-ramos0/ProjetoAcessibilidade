using System;
using System.ComponentModel;

namespace Acessibilidade.Models
{
    public class Agendamentos
    {
        [DisplayName("Código")]
        public int IdAgendamentos { get; set; }

        [DisplayName("Data Agendamento")]
        public DateTime DataAgendamento { get; set; }

        [DisplayName("Serviço")]
        public string TipoServico { get; set; }

        [DisplayName("Observações")]
        public string Observacoes { get; set; }

        [DisplayName("Data Criação")]
        public DateTime DataCriacao { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

        [DisplayName("ID Cadastro")]
        public int IdCadastro { get; set; }

        [DisplayName("ID Posto")]
        public int IdPostos { get; set; }

        // Propriedades de navegação (para exibir informações relacionadas)
        [DisplayName("Nome Posto")]
        public string NomePosto { get; set; }

        [DisplayName("Zona")]
        public string ZonaPosto { get; set; }

        // Método para formatar a data para exibição
        [DisplayName("Data Formatada")]
        public string DataFormatada => DataAgendamento.ToString("dd/MM/yyyy HH:mm");
    }
}
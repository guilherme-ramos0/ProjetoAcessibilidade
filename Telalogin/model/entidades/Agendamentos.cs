using System;

namespace Acessibilidade.Models
{
    public class Agendamento
    {
        public int IdAgendamentos { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string TipoServico { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Status { get; set; }
        public int IdCadastro { get; set; }
        public int IdPostos { get; set; }

        
    }
}
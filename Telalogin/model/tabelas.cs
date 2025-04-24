using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telalogin.model
{
    public class Cliente
    {

        public int ClienteId { get; set; }


        public string Nome { get; set; }

        public DateTime? DataNascimento { get; set; }


        public string Cpf { get; set; }


        public string Endereco { get; set; }


        public string Telefone { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;


        public string Status { get; set; } = "ativo";

        public string Diagnostico { get; set; }

        public string Alergias { get; set; }

        public string MedicamentosEmUso { get; set; }

        public string NecessidadesEspecificas { get; set; }

        public DateTime? UltimoLogin { get; set; }

        public ICollection<Consulta> Consultas { get; set; }
        public ICollection<Tratamento> Tratamentos { get; set; }
        public ICollection<LogAtividade> LogsAtividade { get; set; }
    }

    public class PostoDeSaude
    {
        public int PostoId { get; set; }

        public string Nome { get; set; }


        public string Tipo { get; set; }


        public string Endereco { get; set; }


        public string Telefone { get; set; }


        public string Email { get; set; }

        public string Especialidades { get; set; }

        public int? CapacidadeAtendimento { get; set; }

        public string Acessibilidade { get; set; }


        public string HorarioFuncionamento { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public ICollection<Consulta> Consultas { get; set; }
    }

    public class Zona
    {

        public int ZonaId { get; set; }


        public string Nome { get; set; }

        public string Bairro { get; set; }
    }

    public class Consulta
    {
        public int ConsultaId { get; set; }


        public int ClienteId { get; set; }


        public int PostoId { get; set; }


        public DateTime DataConsulta { get; set; }


        public string TipoConsulta { get; set; }

        public string MedicoNome { get; set; }


        public string Status { get; set; }

        public string Observacoes { get; set; }

        public Cliente Cliente { get; set; }
        public PostoDeSaude PostoDeSaude { get; set; }
    }

    public class Tratamento
    {

        public int TratamentoId { get; set; }


        public int ClienteId { get; set; }


        public string TipoTratamento { get; set; }

        public DateTime? InicioTratamento { get; set; }

        public DateTime? FimTratamento { get; set; }


        public string Status { get; set; }

        public string Descricao { get; set; }

        public Cliente Cliente { get; set; }
    }

    public class LogAtividade
    {

        public int LogId { get; set; }


        public int ClienteId { get; set; }

        public DateTime DataAtividade { get; set; } = DateTime.Now;


        public string TipoAtividade { get; set; }

        public string Descricao { get; set; }

        public Cliente Cliente { get; set; }
    }
}
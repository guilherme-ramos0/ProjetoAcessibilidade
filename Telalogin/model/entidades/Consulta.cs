namespace Acessibilidade.Models
{
    public class Consulta
    {
        public int IdConsultas { get; set; }
        public string NomeMedico { get; set; }
        public string Servico { get; set; }
        public string Observacoes { get; set; }
        public int Cadastro_idCadastro { get; set; }
        public int Postos_idPostos { get; set; }
        public Cadastro Paciente { get; set; }
        public Posto Posto { get; set; }
    }
}
using System;

namespace Acessibilidade.Models
{
    public class Cadastro
    {
        public int IdCadastro { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public int Zonas_idZonas { get; set; }
        public Zona Zona { get; set; }
    }
}
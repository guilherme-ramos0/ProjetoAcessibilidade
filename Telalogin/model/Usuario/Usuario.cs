using ConexaoMySQL.Model.Regra;
using MySql.Data.MySqlClient;
using System;


namespace ConexaoMySQL.Models
{
    class Usuario
    {
        public int IdCadastro { get; set; }
        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string HashSenha { get; set; }
        public string Cpf { get; set; }
        public int Zonas_idZonas { get; set; }
        public Regra Regra { get; set; }

        public static Usuario UserFromDataReader(MySqlDataReader reader)
        {

            return new Usuario
            {
                IdCadastro = Convert.ToInt32(reader["idcadastro"]),
                NomeCompleto = reader["NomeCompleto"].ToString(),
                Telefone = reader["Telefone"].ToString(),
                DataNascimento = Convert.ToDateTime(reader["DataNascimento"]),
                HashSenha = reader["Senha"].ToString(),
                Cpf = reader["Cpf"].ToString(),
                Zonas_idZonas = Convert.ToInt32(reader["Zonas_idZonas"]),
                Regra = new Regra
                {
                    idregra = Convert.ToInt32(reader["idregra"].ToString()),
                    nomeRegra = reader["nomeRegra"].ToString()
                }

            };


        }
    }
}

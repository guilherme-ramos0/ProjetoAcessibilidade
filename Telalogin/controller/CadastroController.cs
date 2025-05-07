using Acessibilidade.DAL;
using Acessibilidade.Models;
using Acessibilidade.Utils;
using MySql.Data.MySqlClient;
using System;

namespace Acessibilidade.Controllers
{
    public class CadastroController
    {
        public bool CadastrarUsuario(Cadastro usuario)
        {
            if (!ValidarUsuario(usuario))
                return false;

            try
            {
                // Criptografa a senha antes de armazenar
                usuario.Senha = CriptografiaUtil.CriptografarSenha(usuario.Senha);

                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Cadastro 
                                    (nomeCompleto, dataNascimento, telefone, cpf, senha, Zonas_idZonas) 
                                    VALUES (@nome, @dataNasc, @telefone, @cpf, @senha, @zonaId)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", usuario.NomeCompleto);
                        cmd.Parameters.AddWithValue("@dataNasc", usuario.DataNascimento);
                        cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                        cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                        cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                        cmd.Parameters.AddWithValue("@zonaId", usuario.Zonas_idZonas);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar usuário: {ex.Message}");
                return false;
            }
        }

        public Cadastro BuscarPorCpf(string cpf)
        {
            Cadastro usuario = null;

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = @"SELECT * FROM Cadastro WHERE cpf = @cpf";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cpf", cpf);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Cadastro
                            {
                                IdCadastro = reader.GetInt32("idCadastro"),
                                NomeCompleto = reader.GetString("nomeCompleto"),
                                DataNascimento = reader.GetDateTime("dataNascimento"),
                                Telefone = reader.GetString("telefone"),
                                Cpf = reader.GetString("cpf"),
                                Senha = reader.GetString("senha"),
                                Zonas_idZonas = reader.GetInt32("Zonas_idZonas")
                            };
                        }
                    }
                }
            }

            return usuario;
        }

        public bool ValidarLogin(string cpf, string senhaDigitada)
        {
            var usuario = BuscarPorCpf(cpf);

            if (usuario == null)
            {
                // Simular tempo de verificação para evitar timing attacks
                CriptografiaUtil.CriptografarSenha("senha_invalida");
                return false;
            }

            return CriptografiaUtil.VerificarSenha(senhaDigitada, usuario.Senha);
        }

        private bool ValidarUsuario(Cadastro usuario)
        {
            // Implemente suas validações aqui
            return !string.IsNullOrEmpty(usuario.NomeCompleto) &&
                   !string.IsNullOrEmpty(usuario.Cpf) &&
                   !string.IsNullOrEmpty(usuario.Senha);
        }
    }
}
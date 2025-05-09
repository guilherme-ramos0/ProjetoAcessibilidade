using Acessibilidade.DAL;
using Acessibilidade.Models;
using Acessibilidade.Utils;
using MySql.Data.MySqlClient;
using System;

namespace Acessibilidade.Controllers
{
    public class LoginController
    {
        public Cadastro ValidarLogin(string cpf, string senhaDigitada)
        {
            try
            {
                Logger.RegistrarInfo($"Tentativa de login iniciada para CPF: {cpf}", cpf, nameof(ValidarLogin));

                var usuario = BuscarUsuarioPorCpf(cpf);

                if (usuario == null)
                {
                    Logger.RegistrarAviso($"CPF não encontrado: {cpf}", cpf, nameof(ValidarLogin));
                    CriptografiaUtil.CriptografarSenha("senha_invalida"); // Timing attack protection
                    return null;
                }

                if (CriptografiaUtil.VerificarSenha(senhaDigitada, usuario.Senha))
                {
                    Logger.RegistrarInfo($"Login bem-sucedido para usuário: {usuario.NomeCompleto}", usuario.Cpf, nameof(ValidarLogin));
                    return usuario;
                }

                Logger.RegistrarAviso($"Senha incorreta para CPF: {cpf}", cpf, nameof(ValidarLogin));
                return null;
            }
            catch (Exception ex)
            {
                Logger.RegistrarErro(ex, cpf, nameof(ValidarLogin));
                throw; // Re-lança a exceção após logar
            }
        }

        public Cadastro BuscarUsuarioPorCpf(string cpf)
        {
            Cadastro usuario = null;

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT idCadastro, nomeCompleto, dataNascimento, 
                                   telefone, cpf, senha, Zonas_idZonas 
                                   FROM Cadastro WHERE cpf = @cpf";

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
            catch (Exception ex)
            {
                Logger.RegistrarErro(ex, cpf, nameof(BuscarUsuarioPorCpf));
                throw;
            }
        }
    }
}
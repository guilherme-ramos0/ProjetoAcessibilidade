using Acessibilidade.DAL;
using Acessibilidade.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Acessibilidade.Controllers
{
    public class CadastroController
    {
        public bool CadastrarUsuario(Cadastro usuario)
        {
            try
            {
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
                // Logar erro
                
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
    }
}
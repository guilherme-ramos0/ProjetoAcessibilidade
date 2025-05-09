using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using Acessibilidade.DAL;

namespace Acessibilidade.Utils
{
    public static class Logger
    {
        public static void RegistrarErro(Exception ex, string usuario = null, string metodoOrigem = null)
        {
            RegistrarLog("ERRO", ex.Message, ex.StackTrace, usuario, metodoOrigem);
        }

        public static void RegistrarAviso(string mensagem, string usuario = null, string metodoOrigem = null)
        {
            RegistrarLog("AVISO", mensagem, null, usuario, metodoOrigem);
        }

        public static void RegistrarInfo(string mensagem, string usuario = null, string metodoOrigem = null)
        {
            RegistrarLog("INFO", mensagem, null, usuario, metodoOrigem);
        }

        private static void RegistrarLog(string tipo, string mensagem, string stackTrace, string usuario, string metodoOrigem)
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO LogSistema 
                                    (Tipo, Mensagem, StackTrace, Usuario, MetodoOrigem, Maquina)
                                    VALUES
                                    (@Tipo, @Mensagem, @StackTrace, @Usuario, @MetodoOrigem, @Maquina)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Tipo", tipo);
                        cmd.Parameters.AddWithValue("@Mensagem", mensagem);
                        cmd.Parameters.AddWithValue("@StackTrace", stackTrace ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Usuario", usuario ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MetodoOrigem", metodoOrigem ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Maquina", Environment.MachineName);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception logEx)
            {
                // Fallback para arquivo de texto se o banco falhar
                string logText = $"[{DateTime.Now}] Falha ao registrar log: {logEx.Message}\n";
                System.IO.File.AppendAllText("log_fallback.txt", logText);
            }
        }
    }
}
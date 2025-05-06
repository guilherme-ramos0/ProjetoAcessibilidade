using Acessibilidade.DAL;
using Acessibilidade.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Acessibilidade.Controllers
{
    public class ZonaController
    {
        public List<Zona> ListarTodos()
        {
            List<Zona> zonas = new List<Zona>();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT idZonas, nome FROM Zonas";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            zonas.Add(new Zona
                            {
                                IdZonas = reader.GetInt32("idZonas"),
                                Nome = reader.GetString("nome")
                            });
                        }
                    }
                }
            }

            return zonas;
        }
    }
}
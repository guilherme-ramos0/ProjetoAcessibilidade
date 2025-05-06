using MySql.Data.MySqlClient;
using System.Configuration;

namespace Acessibilidade.DAL
{
    public class DbConnection
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
using MyManagementApp.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Data.Repositories
{
    public static class DatabaseListRepository
    {
        public static DataTable GetAllDatabase()
        {
            DataTable bcodados = new DataTable();

            using (var conn = ConnectionProvider.GetDatabase())
            {
                conn.Open();

                var query = "SELECT name FROM sys.databases WHERE database_id > 4 ORDER BY name";
                var command = new SqlCommand(query, conn);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(bcodados);
                }
                return bcodados;
            }
        }
    }
}

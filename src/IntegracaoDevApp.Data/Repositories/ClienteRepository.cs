using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegracaoDevApp.Domain.Models;
using MyManagementApp.Data;

namespace IntegracaoDevApp.Data.Repositories
{
    public class ClienteRepository
    {

        public bool Create(Cliente entity)
        {
            var rowsAffected = 0;
            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "INSERT INTO ClienteAtv2510 (CdCliente, Nome) VALUES (@CdCliente, @Nome)";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CdCliente", entity.CdCliente);
                command.Parameters.AddWithValue("@Nome", entity.Nome);

                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }
    }
}

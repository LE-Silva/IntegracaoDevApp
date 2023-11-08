using IntegracaoDevApp.Domain.Entities;
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
    public class UserRepository
    {
        public bool FetchUserCredentials(Usuario user)
        {
            var usuario = new DataTable();
            using(var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var queryString = "SELECT username, senha FROM UsuarioAtv0711 WHERE username = @username AND senha = @password";
                var command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("username", user.Username);
                command.Parameters.AddWithValue("password", user.Password);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(usuario);
                }
            }

            return usuario.Rows.Count > 0;
        }
        public UserRepository() { }
    }
}

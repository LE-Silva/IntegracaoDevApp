using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegracaoDevApp.Domain.Entities;
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

                var query = "INSERT INTO ClienteAtv2510 (CdCliente, Nome, Cpf, TpPessoa, StClientePremium, StAtivo) VALUES (@CdCliente, @Nome, @Cpf, @TpPessoa, @StClientePremium, 1)";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CdCliente", entity.CdCliente);
                command.Parameters.AddWithValue("@Nome", entity.Nome);
                command.Parameters.AddWithValue("@Cpf", entity.Cpf);
                command.Parameters.AddWithValue("@TpPessoa", entity.TpPessoa);
                command.Parameters.AddWithValue("@StClientePremium", entity.StClientePremium);

                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }
        public bool Update(Cliente entity)
        {
            var rowsAffected = 0;
            using ( var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "UPDATE ClienteAtv2510 SET " +
                    "Nome = @Nome, " +
                    "Cpf = @Cpf, " +
                    "TpPessoa = @TpPessoa, " +
                    "StClientePremium = @StClientePremium, " +
                    "StAtivo = @StAtivo " +
                    "WHERE " +
                    "CdCliente = @CdCliente";

                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CdCliente", entity.CdCliente);
                command.Parameters.AddWithValue("@Nome", entity.Nome);
                command.Parameters.AddWithValue("@Cpf", entity.Cpf);
                command.Parameters.AddWithValue("@TpPessoa", entity.TpPessoa);
                command.Parameters.AddWithValue("@StClientePremium", entity.StClientePremium);
                command.Parameters.AddWithValue("@StAtivo", entity.getIsActiveBool(entity.getIsActiveChar()));

                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }
        public bool Delete(string cdcliente)
        {
            var rowsAffected = 0;
            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "DELETE FROM ClienteAtv2510 WHERE CdCliente = @CdCliente";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("CdCliente", cdcliente);

                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }
        public DataTable GetClienteById(string cdcliente)
        {
            var cliente = new DataTable();

            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "SELECT CdCliente, Nome, ISNULL(Cpf, '') AS Cpf, ISNULL(TpPessoa, '') AS TpPessoa, ISNULL(StClientePremium, 0) AS StClientePremium, ISNULL(StAtivo, 0) as StAtivo FROM ClienteAtv2510 WHERE CdCliente = @CdCliente";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("CdCliente", cdcliente);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(cliente);
                }
            }

            return cliente;
        }
        public DataTable GetAllClientes()
        {
            var clientes = new DataTable();

            using(var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "SELECT CdCliente, Nome, ISNULL(Cpf, '') AS Cpf, ISNULL(TpPessoa, '') AS TpPessoa, ISNULL(StClientePremium, 0) AS StClientePremium, ISNULL(StAtivo, 0) as StAtivo FROM ClienteAtv2510";
                var command = new SqlCommand(query, conn);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(clientes);
                }
            }

            return clientes;
        }
        public ClienteRepository()
        {

        }

    }
}

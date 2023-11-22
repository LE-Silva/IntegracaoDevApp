using IntegracaoDevApp.Domain.Entities;
using IntegracaoDevApp.Domain.Entities.PedidoItem;
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
    public class PedidoRepository
    {
        public PedidoRepository() { }

        public int Create(Pedido entity)
        {
            int newId = 0;

            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "INSERT INTO PedidoDevApp (CdCliente, DtAbertura, DtFechamento, Status, Total) VALUES (@CdCliente, GETDATE(), NULL, @Status, 0); " +
                            "SELECT SCOPE_IDENTITY();";

                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CdCliente", entity.CdCliente);
                command.Parameters.AddWithValue("@Status", "A");

                var result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out newId))
                {
                    return newId;
                }
            }

            return newId;
        }

        public bool Delete(string numpedido)
        {
            var rowsAffected = 0;
            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "DELETE FROM PedidoDevApp WHERE NumPedido = @NumPedido";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NumPedido", numpedido);

                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }
        public bool Fechar(string numpedido, string novoStatus)
        {
            var rowsAffected = 0;
            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "UPDATE PedidoDevApp " +
                    " SET Status = @NovoStatus" +
                    " WHERE NumPedido = @NumPedido";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NumPedido", numpedido);
                command.Parameters.AddWithValue("@NovoStatus", novoStatus);

                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }
        public bool CalculaTotalPedido(string numpedido)
        {
            var rowsAffected = 0;
            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "UPDATE PedidoDevApp " +
                    "SET Total = (SELECT SUM(Valor) FROM PedidoItemDevApp WHERE NumPedido = @NumPedido) " +
                    "WHERE NumPedido = @NumPedido ";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NumPedido", numpedido);

                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }
        public DataTable GetAllPedidos()
        {
            DataTable result = new DataTable();

            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "SELECT " +
                    "Numpedido, " +
                    "CdCliente, " +
                    "DtAbertura, " +
                    "DtFechamento, " +
                    "CASE " +
                        "WHEN " +
                        "Status = 'F' THEN 'FECHADO'" +
                        "ELSE 'ABERTO'" +
                    "END AS Status, " +
                    "Total " +
                    "FROM PedidoDevApp";
                var command = new SqlCommand(query, conn);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(result);
                }
            }

            return result;
        }
        public DataSet GetPedidoByNumero(string numpedido)
        {
            DataSet result = new DataSet();

            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "SELECT " +
                    "Numpedido, " +
                    "CdCliente, " +
                    "DtAbertura, " +
                    "DtFechamento, " +
                    "CASE " +
                        "WHEN " +
                        "Status = 'F' THEN 'FECHADO'" +
                        "ELSE 'ABERTO'" +
                    "END AS Status, " +
                    "Total " +
                    "FROM PedidoDevApp WHERE numpedido = @numpedido";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@numpedido", numpedido);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(result);
                }
            }

            return result;
        }
        public bool IsPedidoFechado(string numero)
        {
            DataTable result = new DataTable();

            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "SELECT Status FROM PedidoDevApp WHERE NumPedido = @NumPedido AND Status = 'A'";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NumPedido", numero);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(result);
                }
            }

            return result.Rows.Count != 0;
        }
    }
}

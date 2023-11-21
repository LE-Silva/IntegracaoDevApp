using MyManagementApp.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegracaoDevApp.Domain.Entities.PedidoItem;

namespace IntegracaoDevApp.Data.Repositories
{
    public class PedidoItemRepository
    {
        public bool Create(PedidoItem entity)
        {
            var rowsAffected = 0;
            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "INSERT INTO PedidoItemDevApp (NumPedido, CdProduto, Quantidade, Valor) VALUES (@NumPedido, @CdProduto, @Quantidade, @Valor)";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NumPedido", entity.NumPedido);
                command.Parameters.AddWithValue("@CdProduto", entity.CdProduto);
                command.Parameters.AddWithValue("@Quantidade", entity.Quantidade);
                command.Parameters.AddWithValue("@Valor", entity.Valor);

                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }
        public bool Delete(int seq)
        {
            var rowsAffected = 0;
            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "DELETE FROM PedidoItemDevApp WHERE Seq = @Seq";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Seq", seq);

                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }
        public DataTable GetTodosItensDoPedido(int numpedido)
        {
            DataTable itens = new DataTable();

            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "SELECT NumPedido, Seq, CdProduto, Quantidade, Valor FROM PedidoItemDevApp WHERE NumPedido = @NumPedido";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NumPedido", numpedido);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(itens);
                }
            }

            return itens;
        }

    }
}

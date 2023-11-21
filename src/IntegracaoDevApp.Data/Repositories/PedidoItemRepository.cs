using MyManagementApp.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Data.Repositories
{
    public class PedidoItemRepository
    {
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

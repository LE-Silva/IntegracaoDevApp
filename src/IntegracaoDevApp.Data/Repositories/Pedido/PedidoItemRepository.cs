using MyManagementApp.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Data.Repositories.Pedido
{
    public class PedidoItemRepository
    {
        public DataTable GetAllPedidoItensDoPedido()
        {
            var itensPedido = new DataTable();
            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "SELECT NumPedido, CdProduto, SeqItem, ValorVenda FROM PedidoItemAtv1411";
                var command = new SqlCommand(query, conn);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(itensPedido);
                }
            }

            return itensPedido;
        }
    }
}

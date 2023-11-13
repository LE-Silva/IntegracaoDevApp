using IntegracaoDevApp.Domain.Entities;
using MyManagementApp.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Data.Repositories.Pedido
{
    public class PedidoRepository
    {
        public DataTable getPedidoNumeros()
        {
            var pedidoNumeros = new DataTable();

            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "SELECT NumPedido, CdCliente, Status, ValorPedido, DtAbertura, DtFechamento FROM PedidoAtv1411";
                var command = new SqlCommand(query, conn);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(pedidoNumeros);
                }
            }

            return pedidoNumeros;
        }
        public DataTable getPedido()
        {
            var pedido = new DataTable();

            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "SELECT NumPedido, CdCliente, Status, ValorPedido, DtAbertura, DtFechamento FROM PedidoAtv1411 WHERE NumPedido = @NumPedido";
                var command = new SqlCommand(query, conn);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(pedido);
                }
            }

            return pedido;
        }
    }
}

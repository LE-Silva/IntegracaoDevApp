using IntegracaoDevApp.Domain.Entities;
using IntegracaoDevApp.Domain.Entities.Pedido;
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

        public DataTable GetAllPedidos()
        {
            DataTable result = new DataTable();

            using (var conn = ConnectionProvider.GetConnection())
            {
                conn.Open();

                var query = "SELECT" +
                    " Numpedido" +
                    ", CdCliente" +
                    ", DtAbertura" +
                    ", DtFechamento" +
                    ", Status" +
                    ", Total " +
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

                var query = "SELECT" +
                    " Numpedido" +
                    ", CdCliente" +
                    ", DtAbertura" +
                    ", DtFechamento" +
                    ", Status" +
                    ", Total " +
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
    }
}

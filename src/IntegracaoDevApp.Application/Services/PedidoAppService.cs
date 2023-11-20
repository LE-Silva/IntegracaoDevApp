using IntegracaoDevApp.Data.Repositories;
using IntegracaoDevApp.Domain.Entities;
using IntegracaoDevApp.Domain.Entities.Pedido;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Application.Services
{
    public class PedidoAppService
    {
        PedidoRepository pedidoRepository;
        public PedidoAppService() { pedidoRepository = new PedidoRepository(); }
        public IList<PedidoItem> GetPedidoItems(int numpedido)
        {
            var table = pedidoRepository.GetTodosItensDoPedido(numpedido);
            var list = table.Rows.Cast<PedidoItem>().ToList();
            return list;
        }

        public DataTable GetAllPedidos()
        {
            return pedidoRepository.GetAllPedidos();
        }

        public Pedido GetPedidoByNumero(string numpedido)
        {
            var ds = pedidoRepository.GetPedidoByNumero(numpedido);
            var table = ds.Tables[0];
            var row = table.Rows[0];
            return (
                new Pedido(
                    Convert.ToInt32(row["NumPedido"]),
                    Convert.ToString(row["CdCliente"]),
                    Convert.ToDateTime(row["DtAbertura"]),
                    Convert.ToDateTime(row["DtFechamento"]),
                    Convert.ToString(row["Status"])
                    )
            );
        }
    }
}

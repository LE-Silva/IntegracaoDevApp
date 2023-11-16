using IntegracaoDevApp.Data.Repositories;
using IntegracaoDevApp.Domain.Entities.Pedido;
using System;
using System.Collections.Generic;
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
    }
}

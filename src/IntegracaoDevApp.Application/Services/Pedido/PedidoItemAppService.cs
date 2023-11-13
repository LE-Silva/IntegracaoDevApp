using IntegracaoDevApp.Data.Repositories.Pedido;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Application.Services.Pedido
{
    public class PedidoItemAppService
    {
        PedidoItemRepository pedidoItemRepository;
        public PedidoItemAppService() { pedidoItemRepository = new PedidoItemRepository(); }

        public DataTable GetAllItens()
        {
            return pedidoItemRepository.GetAllPedidoItensDoPedido();
        }
    }
}

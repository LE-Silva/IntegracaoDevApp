using IntegracaoDevApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Application.Services
{
    public class PedidoItemAppService
    {
        PedidoItemRepository PedidoItemRepository;
        public PedidoItemAppService() { PedidoItemRepository = new PedidoItemRepository(); }

        public DataTable GetTodosItensDoPedido(int numpedido)
        {
            return PedidoItemRepository.GetTodosItensDoPedido(numpedido);
        }
    }
}

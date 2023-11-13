using IntegracaoDevApp.Data.Repositories.Pedido;
using IntegracaoDevApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Application.Services.Pedido
{
    public class PedidoAppService
    {
        PedidoRepository pedidoRepository;
        public PedidoAppService() { pedidoRepository = new PedidoRepository(); }

        public DataTable GetAllPedido()
        {
            return pedidoRepository.getPedidoNumeros();
        }
        public DataTable GetPedido(int numpedido)
        {
            return pedidoRepository.getPedido();
        }
        
    }
}

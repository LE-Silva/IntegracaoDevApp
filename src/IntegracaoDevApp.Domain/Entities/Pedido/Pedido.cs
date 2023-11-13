using IntegracaoDevApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Domain.Entities.Pedido
{
    public class Pedido
    {
        public int NumPedido { get; set; }
        public string CdCliente { get; set; }
        public IList<PedidoItem> ItensPedido { get; set; }
        public PedidoStatusEnum PedidoStatus { get; set; }
        public decimal ValorPedido { get; set; }
        public DateTime DtAbertura {  get; set; }
        public DateTime DtFechamento {  get; set; }

    }
}

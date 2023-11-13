using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Domain.Entities.Pedido
{
    public class PedidoItem
    {
        public int NumPedido { get; set; }
        public string CdProduto { get; set; }
        public int SeqItem {  get; set; }
        public decimal ValorVenda { get; set; }

    }
}

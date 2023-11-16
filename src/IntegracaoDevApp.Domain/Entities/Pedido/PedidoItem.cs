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
        public int Seq { get; set; }
        public Produto Produto { get; set; }
        public decimal Valor {  get; set; }
        public PedidoItem(int numpedido, Produto produto,decimal valor)
        {
            NumPedido = numpedido;
            Produto = produto;
            Valor = valor;
        }
        public PedidoItem(int numpedido, int seq, Produto produto, decimal valor)
        {
            NumPedido = numpedido;
            Seq = seq;
            Produto = produto;
            Valor = valor;
        }
    }

}

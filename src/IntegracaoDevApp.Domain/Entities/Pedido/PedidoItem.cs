using IntegracaoDevApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Domain.Entities.PedidoItem
{
    public class PedidoItem
    {
        public int NumPedido { get; set; }
        public int Seq { get; set; }
        public string CdProduto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor {  get; set; }
        public PedidoItem(int numpedido, string produto, decimal quantidade, decimal valor)
        {
            NumPedido = numpedido;
            CdProduto = produto;
            Quantidade = quantidade;
            Valor = valor;
        }
        public PedidoItem(int numpedido, int seq, string produto, decimal valor)
        {
            NumPedido = numpedido;
            Seq = seq;
            CdProduto = produto;
            Valor = valor;
        }

        public Result IsValid()
        {
            var messages = new List<string>();

            if (this.Valor <= 0)
                messages.Add("Valor do produto não pode estar zerado!");

            return Result.Factory.New(messages);
        }
    }

}

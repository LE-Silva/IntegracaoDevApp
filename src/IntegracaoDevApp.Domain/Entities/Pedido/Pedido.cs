using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Domain.Entities.Pedido
{
    public class Pedido
    {
        public int NumPedido { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DtAbertura { get; set; }
        public DateTime DtFechamento {  get; set; }
        public string Status {  get; set; }
        public IList<PedidoItem> ListaItens { get; set; }

        public Pedido(int numpedido, Cliente cliente, DateTime dtabertura, DateTime dtfechamento, string status)
        {
            NumPedido = numpedido;
            Cliente = cliente;
            DtAbertura = dtabertura;
            DtFechamento = dtfechamento;
            Status = status;
        }

        public IList<PedidoItem> GetItensDoPedido()
        {
            return ListaItens;
        }

    }
}

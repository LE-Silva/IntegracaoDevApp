using IntegracaoDevApp.Domain.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Domain.Entities.PedidoItem
{
    public class Pedido
    {
        public int NumPedido { get; set; }
        public string  CdCliente { get; set; }
        public DateTime DtAbertura { get; set; }
        public DateTime DtFechamento {  get; set; }
        public string Status {  get; set; }

        public Pedido(int numpedido, string cliente, DateTime dtabertura, DateTime dtfechamento, string status)
        {
            NumPedido = numpedido;
            CdCliente = cliente;
            DtAbertura = dtabertura;
            DtFechamento = dtfechamento;
            Status = status;
        }

        public Pedido(int numpedido, string cliente, DateTime dtabertura, string status)
        {
            NumPedido = numpedido;
            CdCliente = cliente;
            DtAbertura = dtabertura;
            Status = status;
        }

        public Result IsValid()
        {
            var messages = new List<string>();

            if (string.IsNullOrEmpty(this.CdCliente))
                messages.Add("Código do Cliente está vazio");

            return Result.Factory.New(messages);
        }
    }
}

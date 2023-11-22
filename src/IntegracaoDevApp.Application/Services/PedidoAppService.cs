using IntegracaoDevApp.Data.Repositories;
using IntegracaoDevApp.Domain.Core;
using IntegracaoDevApp.Domain.Entities;
using IntegracaoDevApp.Domain.Entities.PedidoItem;
using MyManagementApp.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Application.Services
{
    public class PedidoAppService
    {
        PedidoRepository pedidoRepository;
        public PedidoAppService() { pedidoRepository = new PedidoRepository(); }
        public Result Create(Pedido pedido)
        {
            var r = pedido.IsValid();
            if (!r.Success)
            {
                return r;
            }

            pedidoRepository.Create(pedido);

            return Result.Factory.True();
        }
        public bool Delete(string numpedido)
        {
            return pedidoRepository.Delete(numpedido);
        }
        public bool Fechar(string numpedido, string status)
        {
            if (status == "FECHADO")
                return pedidoRepository.Fechar(numpedido, "A");
            else
                return pedidoRepository.Fechar(numpedido, "F");
        }
        public DataTable GetAllPedidos()
        {
            return pedidoRepository.GetAllPedidos();
        }
        public Pedido GetPedidoByNumero(string numpedido)
        {
            var ds = pedidoRepository.GetPedidoByNumero(numpedido);
            var table = ds.Tables[0];
            var row = table.Rows[0];
            return (
                new Pedido(
                    Convert.ToInt32(row["NumPedido"]),
                    Convert.ToString(row["CdCliente"]),
                    Convert.ToDateTime(row["DtAbertura"]),
                    //Convert.ToDateTime(row["DtFechamento"]),
                    Convert.ToString(row["Status"])
                    )
            );
        }
        public bool IsPedidoFechado(string numero)
        {
            return pedidoRepository.IsPedidoFechado(numero);
        }
    }
}

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
    public class PedidoItemAppService
    {
        PedidoItemRepository PedidoItemRepository;
        public PedidoItemAppService() { PedidoItemRepository = new PedidoItemRepository(); }
        public DataTable GetTodosItensDoPedido(int numpedido)
        {
            var table = PedidoItemRepository.GetTodosItensDoPedido(numpedido);
            return table;
        }
        public Result Create(PedidoItem item)
        {
            var r = item.IsValid();
            if (!r.Success)
            {
                return r;
            }

            PedidoItemRepository.Create(item);

            return Result.Factory.True();
        }
        public bool Delete(int id)
        {
            return PedidoItemRepository.Delete(id);
        }
        public bool DeleteTodosItensPedido(string numpedido)
        {
            return PedidoItemRepository.DeteteTodosItensPedido(numpedido);
        }
    }
}

using IntegracaoDevApp.Data.Repositories;
using IntegracaoDevApp.Domain.Core;
using IntegracaoDevApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Application.Services
{
    public class ClienteAppService
    {
        ClienteRepository clienteRepository;

        public ClienteAppService() { clienteRepository = new ClienteRepository(); }

        public bool Create(Cliente cliente)
        {
            return clienteRepository.Create(cliente);
        }
        public bool Delete(string cdcliente)
        {
            return clienteRepository.Delete(cdcliente);
        }
        public bool Update(Cliente cliente)
        {
            return clienteRepository.Update(cliente);
        }
        public DataTable GetCliente(string cdcliente)
        {
            return clienteRepository.GetClienteById(cdcliente);
        }
        public DataTable GetAllClientes()
        {
            return clienteRepository.GetAllClientes();
        }


        public Result CreateWithResult(Cliente cliente)
        {
            var r = cliente.IsValid();
            if (!r.Success)
            {
                return r;
            }

            clienteRepository.Create(cliente);

            return Result.Factory.True();
        }
    }
}

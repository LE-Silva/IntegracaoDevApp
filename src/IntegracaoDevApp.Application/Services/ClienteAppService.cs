using IntegracaoDevApp.Data.Repositories;
using IntegracaoDevApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Application.Services
{
    public class ClienteAppService
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public ClienteAppService() { }

        public bool Create(Cliente cliente)
        {
            return clienteRepository.Create(cliente);
        }
    }
}

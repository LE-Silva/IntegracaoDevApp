using IntegracaoDevApp.Data.Repositories;
using IntegracaoDevApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Application.Services
{
    public class AuthService
    {
        UserRepository usuarioRepository = new UserRepository();

        public AuthService() { usuarioRepository = new UserRepository(); }

        public bool Login(Usuario user)
        {
            return usuarioRepository.FetchUserCredentials(user);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Domain.Entities
{
    public class Cliente
    {
        public bool Selected { get; set; }
        public string CdCliente { get; }
        public string Nome { get; }
        public string Cpf { get; }
        public string TpPessoa { get; }
        public bool StClientePremium { get; }
        public bool StAtivo { get; }

        public Cliente(string cdCliente, string nome, string cpf, string tpPessoa, bool stClientePremium, bool stAtivo)
        {
            CdCliente = cdCliente;
            Nome = nome;
            Cpf = cpf;
            TpPessoa = tpPessoa;
            StClientePremium = stClientePremium;
            StAtivo = stAtivo;
        }
    }
}

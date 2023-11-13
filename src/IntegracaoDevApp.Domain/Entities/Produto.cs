﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDevApp.Domain.Entities
{
    public class Produto
    {
        public bool Selected { get; set; }
        public string CdProduto { get; }
        public string Descricao { get; }
        public bool IsActive { get; }
        public DateTime DtValidade { get; }
        public decimal Valor { get;}

        public Produto(string cdProduto, string descricao, bool isActive, DateTime dtValidade, decimal valor)
        {
            CdProduto = cdProduto;
            Descricao = descricao;
            IsActive = isActive;
            DtValidade = dtValidade;
            Valor = valor;
        }

        public char getIsActiveChar()
        {
            if (!IsActive) return ('0');
            return ('S');
        }
        public bool getIsActiveBool(char isActiveChar)
        {
            if (isActiveChar == '0')
                return false;
            return true;
        }
    }
}

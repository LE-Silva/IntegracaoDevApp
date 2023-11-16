using IntegracaoDevApp.Domain.Core;
using System;
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

        public Result IsValid()
        {
            var messages = new List<string>();

            if (string.IsNullOrEmpty(this.CdProduto))
                messages.Add("Código do produto precisa estar preenchido");

            if (string.IsNullOrEmpty(this.Descricao))
                messages.Add("Produto não pode ter descrição vazia");

            if (this.Valor <= 0)
                messages.Add("Valor do produto não pode estar zerado");

            return Result.Factory.New(messages);
        }
    }
}

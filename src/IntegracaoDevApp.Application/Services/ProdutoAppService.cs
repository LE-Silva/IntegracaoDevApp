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
    public class ProdutoAppService
    {
        ProdutoRepository produtoRepository;
        public ProdutoAppService() { produtoRepository = new ProdutoRepository(); }
        public Result Create(Produto produto)
        {
            var r = produto.IsValid();
            if (!r.Success)
            {
                return r;
            }
            produtoRepository.Create(produto);

            return Result.Factory.True();
        }
        public bool Delete(string produto)
        {
            return produtoRepository.Delete(produto);
        }
        public Result Update(Produto produto)
        {

            var r = produto.IsValid();
            if (!r.Success)
            {
                return r;
            }
            produtoRepository.Update(produto);

            return Result.Factory.True();
        }
        public DataTable GetById(string cdproduto)
        {
            return produtoRepository.GetProdutoPorID(cdproduto);
        }
        public DataTable GetAll()
        {
            return produtoRepository.GetAll();
        }
    }
}

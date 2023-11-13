using IntegracaoDevApp.Data.Repositories;
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
        public bool Create(Produto produto)
        {
            return produtoRepository.Create(produto);
        }
        public bool Delete(string produto)
        {
            return produtoRepository.Delete(produto);
        }
        public bool Update(Produto produto)
        {
            return produtoRepository.Update(produto);
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

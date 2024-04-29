using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ProdutoService
    {
        private readonly ProdutoRepository _repository;

        public ProdutoService()
        {
            _repository = new ProdutoRepository();
        }

        public Produto CadastrarProduto(int id, string nome, decimal preco, Fornecedor fornecedor)
        {
            var produto = new Produto
            {
                Id = id,
                Nome = nome,
                Preco = preco,
                Fornecedor = fornecedor
            };

            _repository.Adicionar(produto);
            return produto;
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}

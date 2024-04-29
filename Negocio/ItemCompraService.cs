using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ItemCompraService
    {
        private readonly ItemCompraRepository _repository;

        public ItemCompraService()
        {
            _repository = new ItemCompraRepository();
        }

        public void CadastrarItemCompra(int quantidade, decimal preco, Compra compra, Produto produto)
        {
            var itemCompra = new ItemCompra()
            {
                Quantidade = quantidade,
                Preco = preco,
                Compra = compra,
                Produto = produto
            };
            _repository.Adicionar(itemCompra);
        }

        public IEnumerable<ItemCompra> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}

using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ItemVendaService
    {
        private readonly ItemVendaRepository _repository;

        public ItemVendaService()
        {
            _repository = new ItemVendaRepository();
        }

        public ItemVenda CadastrarItemVenda(int quantidade, decimal preco, decimal desconto, Venda venda, Produto produto)
        {
            var itemVenda = new ItemVenda()
            {
                Quantidade = quantidade,
                Preco = preco,  
                Desconto = desconto,
                Venda = venda, 
                Produto = produto
            };
            _repository.Adicionar(itemVenda);
            return itemVenda;
        }

        public IEnumerable<ItemVenda> ObterTodos()
        {
            return _repository.ObterTodos();
        }


    }
}

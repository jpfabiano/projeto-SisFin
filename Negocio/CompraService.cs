using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CompraService
    {
        private readonly CompraRepository _repository;

        public CompraService()
        {
            _repository = new CompraRepository();
        }

        public Compra CadastrarCompra(int id, DateTime instance, string descricao, double desconto, double valor_total, Fornecedor fornecedor, ContaPagar contaPagar)
        {
            var compra = new Compra()
            {
                Id = id,
                Instance = instance,
                Descricao = descricao,
                Desconto = desconto,
                Valor_total = valor_total,
                Fornecedor = fornecedor,
                ContaPagar = contaPagar
            };
            _repository.Adicionar(compra);
            return compra;
        }

        public IEnumerable<Compra> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}

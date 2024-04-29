using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VendaService
    {
        private readonly VendaRepository _repository;

        public VendaService()
        {
            _repository = new VendaRepository();
        }   

        public Venda Adicionar(int id, DateTime instance, string descricao, double desconto, double valor_total, Cliente cliente, ContaReceber contaReceber)
        {
            var venda = new Venda
            {
                Id = id,
                Instance = instance,
                Descricao = descricao,
                Desconto = desconto,
                Valor_total = valor_total,
                Cliente = cliente,
                ContaReceber = contaReceber
            };

            _repository.Adicionar(venda);
            return venda;
        }

        public IEnumerable<Venda> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}

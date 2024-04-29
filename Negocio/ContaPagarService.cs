using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ContaPagarService
    {
        private readonly ContaPagarRepository _repository;

        public ContaPagarService() 
        {
            _repository = new ContaPagarRepository();
        }
        
        public ContaPagar CadastrarContaPagar(int id, decimal valor, DateTime dataCadastro, DateTime dataVencimento, MeioPagamento meioPagamento, EstadoPagamento situacao, Conta conta) 
        {
            var contasPagar = new ContaPagar
            {
                Id = id,
                Valor = valor,
                DataCadastro = dataCadastro,
                DataVencimento = dataVencimento,
                Meiopagamento = meioPagamento,
                Situacao = situacao,
                Conta = conta
            };
            _repository.Adicionar(contasPagar);
            return contasPagar;
        }

        public IEnumerable<ContaPagar> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}

using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{   
    public class ContaReceberService
    {
        private readonly ContaReceberRepository _repository;

        public ContaReceberService()
        {
            _repository = new ContaReceberRepository();
        }

        public ContaReceber CadastrarContaReceber(int id, decimal valor, DateTime dataCadastro, DateTime dataVencimento, DateTime dataRecebimento, decimal valorRecebido, MeioPagamento meioPagamento, EstadoPagamento situacao, Conta conta , ControleCaixa controleCaixa)
        {
            var contaReceber = new ContaReceber()
            {
                Id = id,
                Valor = valor,
                DataCadastro = dataCadastro,
                DataVencimento = dataVencimento,
                DataRecebimento = dataRecebimento,
                ValorRecebido = valorRecebido,
                MeioPagamento = meioPagamento,
                Situacao = situacao,
                Conta = conta,
                ControleCaixa = controleCaixa
            };
            _repository.Adicionar(contaReceber);
            return contaReceber;
        }

        public IEnumerable<ContaReceber> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}

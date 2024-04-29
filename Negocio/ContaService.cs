using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ContaService
    {
        private readonly ContaRepository _repository;

        public ContaService()
        {
            _repository = new ContaRepository();
        }

        public Conta CadastrarConta(int id, string descricao, TipoConta tipo, bool status, Categoria categoria)
        {
            var conta = new Conta()
            {
                Id = id,
                Descricao = descricao,
                Tipo = tipo, 
                Status = status,
                Categoria = categoria
            };
            _repository.Adicionar(conta);
            return conta;
        }

        public IEnumerable<Conta> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}

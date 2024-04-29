using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CaixaService
    {
        private readonly CaixaRepository _repository;

        public CaixaService()
        {
            _repository = new CaixaRepository();
        }

        public Caixa CadastrarCaixa(int id, string nome)
        {
            var caixa = new Caixa
            {
                Id = id,
                Nome = nome,
            };
            _repository.Adicionar(caixa);
            return caixa;
        }

        public IEnumerable<Caixa> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}

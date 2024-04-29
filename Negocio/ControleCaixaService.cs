using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ControleCaixaService
    {
        private readonly ControleCaixaRepository _repository;

        public ControleCaixaService()
        {
            _repository = new ControleCaixaRepository();
        }

        public ControleCaixa CadastrarControleCaixa(int id, decimal valor, DateTime data, Caixa caixa)
        {
            var controleCaixa = new ControleCaixa()
            {
                Id = id,
                Valor = valor,
                Data = data,
                Caixa = caixa
            };
            _repository.Adicionar(controleCaixa);
            return controleCaixa;
        }

        public IEnumerable<ControleCaixa> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}

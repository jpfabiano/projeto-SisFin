using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ControleCaixaRepository
    {
        private static List<ControleCaixa> _controlesCaixa = new List<ControleCaixa>();

        public void Adicionar(ControleCaixa controleCaixa)
        {
            _controlesCaixa.Add(controleCaixa);
        }

        public IEnumerable<ControleCaixa> ObterTodos()
        {
            return _controlesCaixa;
        }
    }
}

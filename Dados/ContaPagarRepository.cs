using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaPagarRepository
    {
        private static List<ContaPagar> _contasPagar = new List<ContaPagar>();

        public void Adicionar(ContaPagar contaPagar)
        {
            _contasPagar.Add(contaPagar);
        }

        public IEnumerable<ContaPagar> ObterTodos()
        {
            return _contasPagar;
        }
    }
}

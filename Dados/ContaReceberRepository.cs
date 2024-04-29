using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaReceberRepository
    {
        private static List<ContaReceber> _contasReceber = new List<ContaReceber>();

        public void Adicionar(ContaReceber contaReceber)
        {
            _contasReceber.Add(contaReceber);
        }

        public IEnumerable<ContaReceber> ObterTodos()
        {
            return _contasReceber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ControleCaixa
    {
        private int id;
        private decimal valor;
        private DateTime data;
        private Caixa caixa;

        public int Id { get => id; set => id = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DateTime Data { get => data; set => data = value; }
        public Caixa Caixa { get => caixa; set => caixa = value; }
    }
}

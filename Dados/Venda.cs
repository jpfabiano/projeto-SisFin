using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Venda
    {
        private int id;
        private DateTime instance;
        private string descricao;
        private double desconto;
        private double valor_total;
        private Cliente cliente;
        private ContaReceber contaReceber;

        public int Id { get => id; set => id = value; }
        public DateTime Instance { get => instance; set => instance = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public double Valor_total { get => valor_total; set => valor_total = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public ContaReceber ContaReceber { get => contaReceber; set => contaReceber = value; }
    }
}

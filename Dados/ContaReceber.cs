using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaReceber
    {
        private int id;
        private decimal valor;
        private DateTime dataCadastro;
        private DateTime dataVencimento;
        private DateTime dataRecebimento;
        private decimal valorRecebido;
        private MeioPagamento meioPagamento;
        private EstadoPagamento situacao;
        private Conta conta;
        private ControleCaixa controleCaixa;

        public int Id { get => id; set => id = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public DateTime DataRecebimento { get => dataRecebimento; set => dataRecebimento = value; }
        public decimal ValorRecebido { get => valorRecebido; set => valorRecebido = value; }
        public MeioPagamento MeioPagamento { get => meioPagamento; set => meioPagamento = value; }
        public EstadoPagamento Situacao { get => situacao; set => situacao = value; }
        public Conta Conta { get => conta; set => conta = value; }
        public ControleCaixa ControleCaixa { get => controleCaixa; set => controleCaixa = value; }
    }
}

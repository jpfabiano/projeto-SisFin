using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaPagar
    {
        private int id;
        private decimal valor;
        private DateTime dataCadastro;
        private DateTime dataVencimento;
        private MeioPagamento meiopagamento;
        private EstadoPagamento situacao;
        private Conta conta;

        public int Id { get => id; set => id = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public MeioPagamento Meiopagamento { get => meiopagamento; set => meiopagamento = value; }
        public EstadoPagamento Situacao { get => situacao; set => situacao = value; }
        public Conta Conta { get => conta; set => conta = value; }
    }
}

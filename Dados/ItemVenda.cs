using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ItemVenda
    {
        private int quantidade;
        private decimal preco;
        private decimal desconto;
        private Venda venda;
        private Produto produto;

        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public decimal Desconto { get => desconto; set => desconto = value; }
        public Venda Venda { get => venda; set => venda = value; }
        public Produto Produto { get => produto; set => produto = value; }
    }
}

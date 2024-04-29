using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ItemCompra
    {
        private int quantidade;
        private decimal preco;
        private Produto produto;
        private Compra compra;

        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public Produto Produto { get => produto; set => produto = value; }
        public Compra Compra { get => compra; set => compra = value; }
    }
}

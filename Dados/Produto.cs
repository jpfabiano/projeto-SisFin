using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Produto
    {
        private int id;
        private string nome;
        private decimal preco;
        private Fornecedor fornecedor;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }
    }
}

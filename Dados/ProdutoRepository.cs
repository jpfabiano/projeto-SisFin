﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ProdutoRepository
    {
        private static List<Produto> _produtos = new List<Produto>();

        public void Adicionar(Produto produtos)
        {
            _produtos.Add(produtos); 
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _produtos;
        }
    }
}

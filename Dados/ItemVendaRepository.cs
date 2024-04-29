using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ItemVendaRepository
    {
        private static List<ItemVenda> _itensVenda = new List<ItemVenda>();

        public void Adicionar(ItemVenda itemVenda)
        {
            _itensVenda.Add(itemVenda);
        }

        public IEnumerable<ItemVenda> ObterTodos() 
        {
            return _itensVenda;
        }
    }
 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ItemCompraRepository
    {
        private static List<ItemCompra> _compras = new List<ItemCompra>();
        
        public void Adicionar(ItemCompra itemCompra)
        {
            _compras.Add(itemCompra);
        }

        public IEnumerable<ItemCompra> ObterTodos()
        {
            return _compras;
        }
    }
}

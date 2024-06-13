using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuAppPods.Model
{
    public class Carrinho
    {
        private List<Itens> _itens = new List<Itens>();

        public void AddItem(Itens item)
        {
            _itens.Add(item);
        }

        public void RemoveItem(Itens item)
        {
            _itens.Remove(item);
        }

        public List<Itens> GetItems()
        {
            return _itens;
        }
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuAppPods.Model
{
    public class Itens
    {
        [PrimaryKey, AutoIncrement]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public Itens()
        {
            Id = Guid.NewGuid();
        }
    }
}

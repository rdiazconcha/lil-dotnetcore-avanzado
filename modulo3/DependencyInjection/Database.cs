using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Database : IDatabase
    {
        public long Ticks { get; set; }

        public Database()
        {
            Ticks = DateTime.Now.Ticks;
        }

        public IEnumerable<string> GetProducts()
        {
            return new[] { "Naranja", "Yogurth", "Queso" };
        }

        public void Create()
        {
            //...
        }
    }
}

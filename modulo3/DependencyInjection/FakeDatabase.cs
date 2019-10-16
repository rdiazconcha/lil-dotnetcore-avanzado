using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class FakeDatabase : IDatabase
    {
        public long Ticks { get; set; } = 1;

        public void Create()
        {
        }

        public IEnumerable<string> GetProducts()
        {
            return null;
        }
    }
}

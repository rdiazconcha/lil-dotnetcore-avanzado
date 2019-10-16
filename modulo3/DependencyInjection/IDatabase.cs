using System.Collections.Generic;

namespace DependencyInjection
{
    public interface IDatabase
    {
        long Ticks { get; set; }
        void Create();
        IEnumerable<string> GetProducts();
    }
}
using System.Collections.Generic;
using System.Linq;

namespace LearnASP.netMVCFromEdureka3._1.Models
{
    public interface IStoreRepository
    {
        public IEnumerable<Product> Products { get; }
    }
}

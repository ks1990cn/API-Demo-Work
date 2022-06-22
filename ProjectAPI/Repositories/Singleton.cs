using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Repositories
{
    public class Singleton : ISingleton
    {
        Guid g;
        public Singleton()
        {
            g = Guid.NewGuid();
        }
        public string GetList()
        {
            return g.ToString();
        }
    }
}

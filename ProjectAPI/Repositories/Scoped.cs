using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Repositories
{
    public class Scoped : IScoped
    {

        Guid g;
        public Scoped()
        {
            g = Guid.NewGuid();
        }
        public string GetList()
        {
            return g.ToString();
        }
    }
}

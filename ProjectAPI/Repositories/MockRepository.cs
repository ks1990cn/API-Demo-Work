using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Repositories
{
    public class MockRepository : IMockRepository
    {
        Guid g;
        public MockRepository()
        {
            g = Guid.NewGuid();
        }
        public string GetList()
        {
            return g.ToString();
        }
    }
}

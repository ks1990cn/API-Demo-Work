using Microsoft.EntityFrameworkCore;
using ProjectAPI.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
   public class TestExtentions
    {
        public DbContextOptions<QuotesDbContext> dbOption;
        public TestExtentions()
        {
            dbOption = new DbContextOptionsBuilder<QuotesDbContext>()
                        .UseSqlServer("tanmayString")
                        .Options;
        }
    }
}

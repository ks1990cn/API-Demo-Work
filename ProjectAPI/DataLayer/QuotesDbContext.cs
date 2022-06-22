using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.DataLayer
{
    public class QuotesDbContext : DbContext
    {
        public QuotesDbContext(DbContextOptions<QuotesDbContext> options):base(options)
        {

        }
        public DbSet<Quotes> Quotes { get; set; }
        public DbSet<EmployeeModel> employeeModels { get; set; }
        public DbSet<bro> bros { get; set; }
    }
}

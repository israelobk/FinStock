using FinStock.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinStock.Domain.Context
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }

        //public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
/*        public DbSet<Portfolio> Portfolios { get; set; }
*/    }
}

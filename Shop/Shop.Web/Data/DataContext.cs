using Shop.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Shop.Web.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Product> Products { set; get; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}

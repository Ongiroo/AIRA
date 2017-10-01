using AIRA.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Data
{
    public class ProductDbContext : DbContext
    {
        static ProductDbContext()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProductDbContext>());
        }

        public DbSet<Product> Products { get; set; }
    }
}

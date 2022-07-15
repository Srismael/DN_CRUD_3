using Microsoft.EntityFrameworkCore;
using Store.Core.Inventories;
using Store.Core.Sale;
using Store.Core.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess
{
    public class StoreDataContext : DbContext
    {
        public StoreDataContext(DbContextOptions<StoreDataContext> options) : base(options)
        {

        }
        public DbSet<user> Users { get; set; }

        public DbSet<sale> sales { get; set; }

        public DbSet<sale_detail> salesdetail { get; set; }

        public DbSet<brand> brands { get; set; }

        public DbSet<category> categories { get; set; }

        public DbSet<product> products { get; set; }
    }
}

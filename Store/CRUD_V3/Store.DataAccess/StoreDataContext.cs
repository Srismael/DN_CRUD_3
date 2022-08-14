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
        public virtual DbSet<user> Users { get; set; }

        public virtual DbSet<sale> sales { get; set; }

        public virtual DbSet<sale_detail> salesdetail { get; set; }

        public virtual DbSet<brand> brands { get; set; }

        public virtual DbSet<category> categories { get; set; }

        public virtual DbSet<product> products { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sale_detail>().HasKey(vi => new { vi.Id_product, vi.Id_sale });
        }
    }
}

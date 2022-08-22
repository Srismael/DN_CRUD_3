using Microsoft.EntityFrameworkCore;
using Store.Core.Inventories;
using Store.Core.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories
{
    public class SaleDetailRepository : Repository<int, sale_detail>
    {
        public SaleDetailRepository(StoreDataContext context) : base(context)
        {

        }

        public override async Task<sale_detail> AddAsync(sale_detail entity)
        {
            var Products = await Context.products.FindAsync(entity.product.Id);
            var Sale = await Context.sales.FindAsync(entity.sale.Id);

            await Context.salesdetail.AddAsync(entity);
            

            await Context.SaveChangesAsync();

            return entity;
        }

        public override async Task<sale_detail> GetAsync(int id)
        {
            var saledetails = await Context.salesdetail.Include(x => x.sale).Include(x => x.product).FirstOrDefaultAsync(x => x.Id == id);
            return saledetails;
        }

        public override async Task<sale_detail> UpdateAsync(sale_detail entity)
        {
            var product = await Context.products.FindAsync(entity.product.Id);
            var Sale = await Context.sales.FindAsync(entity.sale.Id);
            entity.product = null;
            entity.sale = null;
            //Sale.sales.Add(entity);
            //product.salesdetail.Add(entity);

            var saledetail = await Context.salesdetail.FindAsync(entity.Id);


            await Context.SaveChangesAsync();

            return saledetail;
        }
    }
}

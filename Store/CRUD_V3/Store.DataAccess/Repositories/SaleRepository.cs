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
    public class SaleRepository : Repository<int, sale>
    {
        public SaleRepository(StoreDataContext context) : base(context)
        {

        }

        public override async Task<sale> AddAsync(sale entity)
        {
            var user = await Context.Users.FindAsync(entity.user.Id);
            
            await Context.sales.AddAsync(entity);
            user.sales.Add(entity);

            await Context.SaveChangesAsync();

            return entity;
        }

        public override async Task<sale> GetAsync(int id)
        {
            var sale = await Context.sales.Include(x => x.user).FirstOrDefaultAsync(x => x.Id == id);
            return sale;
        }

        public override async Task<sale> UpdateAsync(sale entity)
        {
            var user = await Context.Users.FindAsync(entity.user.Id);
            
            entity.user = null;
            user.sales.Add(entity);

            var sale = await Context.sales.FindAsync(entity.Id);


            await Context.SaveChangesAsync();

            return sale;
        }
    }
}

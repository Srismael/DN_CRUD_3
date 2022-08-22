using Microsoft.EntityFrameworkCore;
using Store.Core.Inventories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories
{
    public class ProductRepository : Repository<int, product>
    {
        public ProductRepository(StoreDataContext context) : base(context)
        {
        }

        public override async Task<product> AddAsync(product entity)
        {
            var category = await Context.categories.FindAsync(entity.Category.Id);
            var brand = await Context.brands.FindAsync(entity.Brand.Id);


            
            await Context.products.AddAsync(entity);
            brand.poducts.Add(entity);
            category.Products.Add(entity);

            await Context.SaveChangesAsync();

            

            return entity;
        }

        public override async Task<product> GetAsync(int id)
        {
            var member = await Context.products.Include(x => x.Category).Include(x => x.Brand).FirstOrDefaultAsync(x => x.Id == id);
            return member;
        }

        public override async Task<product> UpdateAsync(product entity)
        {
            var brand = await Context.brands.FindAsync(entity.Brand.Id);
            var categories = await Context.categories.FindAsync(entity.Category.Id);
            entity.Brand = null;
            entity.Category = null;
            brand.poducts.Add(entity);
            categories.Products.Add(entity);

            var product = await Context.products.FindAsync(entity.Id);


            await Context.SaveChangesAsync();

            return product;
        }

    }
}

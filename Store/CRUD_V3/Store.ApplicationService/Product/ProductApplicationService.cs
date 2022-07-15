using Microsoft.EntityFrameworkCore;
using Store.Core.Inventories;
using Store.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService.Product
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IRepository<int, product> _repository;

        public ProductApplicationService(IRepository<int, product> repository)
        {
            _repository = repository;
        }

        public async Task<int> AddProductAsync(product product)
        {
            await _repository.AddAsync(product);
            return product.Id;
        }

        public async Task DeleteProductAsync(int productId)
        {
            await _repository.DeleteAsync(productId);
        }

        public async Task EditProductAsync(product product)
        {
            await _repository.UpdateAsync(product);
        }

        public async Task<List<product>> GetAllProductAsync()
        {
            return await _repository.GetAllAsync().ToListAsync();
        }

        public async Task<product> GetProductAsync(int productId)
        {
            return await _repository.GetAsync(productId);
        }
    }
}

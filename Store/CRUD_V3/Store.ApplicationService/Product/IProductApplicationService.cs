using Store.Core.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService.Product
{
    public interface IProductApplicationService
    {
        Task<List<product>> GetAllProductAsync();

        Task<int> AddProductAsync(product product);

        Task DeleteProductAsync(int productId);

        Task<product> GetProductAsync(int productId);

        Task EditProductAsync(product product);
    }
}

using Store.Core.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService.Brand
{
    public interface IBrandApplicationService
    {
        Task<List<brand>> GetAllBrandAsync();

        Task<int> AddBrandAsync(brand brand);

        Task DeleteBrandAsync(int brandId);

        Task<brand> GetBrandAsync(int brandIdId);

        Task EditBrandAsync(brand brand);
    }
}

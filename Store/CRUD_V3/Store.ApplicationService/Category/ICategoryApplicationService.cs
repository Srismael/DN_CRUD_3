using Store.Core.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService.Category
{
    public interface ICategoryApplicationService
    {
        Task<List<category>> GetAllCategoryAsync();

        Task<int> AddCategoryAsync(category category);

        Task DeleteCategoryAsync(int categoryId);

        Task<category> GetCategoryAsync(int categoryId);

        Task EditCategoryAsync(category category);

    }
}

using Store.Core.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService.Sale_Detail
{
    public interface ISaleDetailsApplicationService
    {
        Task<List<sale_detail>> GetAllSaleDetailAsync();

        Task<int> AddSaleDetailAsync(sale_detail sale_detail);

        Task DeleteSaleDetailAsync(int sale_detailId);

        Task<sale_detail> GetSaleDetailAsync(int sale_detailId);

        Task EditSaleDetailAsync(sale_detail sale_detailI);

    }
}

using Store.Core.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService.Sale
{
    public interface ISaleApplicationService
    {
        Task<List<sale>> GetAllSaleAsync();

        Task<int> AddSaleAsync(sale sale);

        Task DeleteSaleAsync(int saleId);

        Task<sale> GetSaleAsync(int saleId);

        Task EditSaleAsync(sale sale);
    }
}

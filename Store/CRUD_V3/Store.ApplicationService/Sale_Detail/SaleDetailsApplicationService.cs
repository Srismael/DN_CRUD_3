using Microsoft.EntityFrameworkCore;
using Store.Core.Sale;
using Store.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService.Sale_Detail
{
    public class SaleDetailsApplicationService : ISaleDetailsApplicationService
    {
        private readonly IRepository<int, sale_detail> _repository;

        public async Task<int> AddSaleDetailAsync(sale_detail sale_detail)
        {
            await _repository.AddAsync(sale_detail);
            return sale_detail.Id;
        }

        public async Task DeleteSaleDetailAsync(int sale_detailId)
        {
            await _repository.DeleteAsync(sale_detailId);
        }

        public async Task EditSaleDetailAsync(sale_detail sale_detailI)
        {
            await _repository.UpdateAsync(sale_detailI);
        }

        public async Task<List<sale_detail>> GetAllSaleDetailAsync()
        {
            return await _repository.GetAllAsync().ToListAsync();
        }

        public async Task<sale_detail> GetSaleDetailAsync(int sale_detailId)
        {
            return await _repository.GetAsync(sale_detailId);
        }
    }


}

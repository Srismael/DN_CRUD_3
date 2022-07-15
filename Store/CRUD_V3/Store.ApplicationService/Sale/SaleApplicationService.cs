using Microsoft.EntityFrameworkCore;
using Store.Core.Sale;
using Store.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService.Sale
{
    public class SaleApplicationService : ISaleApplicationService
    {
        private readonly IRepository<int, sale> _repository;


        public SaleApplicationService(IRepository<int, sale> repository)
        {
            _repository = repository;
        }

        public async Task<int> AddSaleAsync(sale sale)
        {
            await _repository.AddAsync(sale);
            return sale.Id;
        }

        public async Task DeleteSaleAsync(int saleId)
        {
            await _repository.DeleteAsync(saleId);
        }

        public async Task EditSaleAsync(sale sale)
        {
            await _repository.UpdateAsync(sale);
        }

        public async Task<List<sale>> GetAllSaleAsync()
        {
            return await _repository.GetAllAsync().ToListAsync();
        }

        public async Task<sale> GetSaleAsync(int saleId)
        {
            return await _repository.GetAsync(saleId);
        }
    }
}

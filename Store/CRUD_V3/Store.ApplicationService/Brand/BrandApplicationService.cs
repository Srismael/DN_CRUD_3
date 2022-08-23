
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Store.Core.Inventories;
using Store.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService.Brand
{
    public class BrandApplicationService : IBrandApplicationService
    {
        private readonly IRepository<int, brand> _repository;
       // private readonly IMapper _mapper;
        public BrandApplicationService(IRepository<int, brand> repository /*, IMapper mapper*/)
        {
            _repository = repository;
            //_mapper = mapper;
        }

        public async Task<int> AddBrandAsync(brand brand)
        {
            await _repository.AddAsync(brand);
            return brand.Id;
        }

        public async Task DeleteBrandAsync(int brandId)
        {
            await _repository.DeleteAsync(brandId);
        }

        public async Task EditBrandAsync(brand brand)
        {
            await _repository.UpdateAsync(brand);
        }

        public async Task<List<brand>> GetAllBrandAsync()
        {
            return await _repository.GetAllAsync().ToListAsync();
        }

        public Task<brand> GetBrandAsync(int brandIdId)
        {
            return _repository.GetAsync(brandIdId);
        }
    }
}

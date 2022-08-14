using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Store.Core.Inventories;
using Store.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService.Category
{
    public class CategoryApplicationService : ICategoryApplicationService
    {
        private readonly IRepository<int, category> _repository;

        //private readonly IMapper _mapper;

        public CategoryApplicationService(IRepository<int, category> repository /*, IMapper mapper*/)
        {
            _repository = repository;
            //_mapper = mapper;
                
        }

        public async Task<int> AddCategoryAsync(category category)
        {
            await _repository.AddAsync(category);
            return category.Id;
        }

        public async Task DeleteCategoryAsync(int categoryId)
        {
            await _repository.DeleteAsync(categoryId);
        }

        public async Task EditCategoryAsync(category category)
        {
            await _repository.UpdateAsync(category);
        }

        public async Task<List<category>> GetAllCategoryAsync()
        {
            return await _repository.GetAllAsync().ToListAsync();
        }

        public async Task<category> GetCategoryAsync(int categoryId)
        {
            return await _repository.GetAsync(categoryId);
        }

    }
}

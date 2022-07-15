using Microsoft.EntityFrameworkCore;
using Store.Core.User;
using Store.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService.User
{
    public class UserApplicationService : IUserApplicationService
    {
        private readonly IRepository<int, user> _repository;


        public UserApplicationService(IRepository<int, user> repository)
        {
            _repository = repository;

        }

        public async Task<int> AddUserAsync(user user)
        {
            await _repository.AddAsync(user);
            return user.Id;
        }

        public async Task DeleteUserAsync(int userId)
        {
            await _repository.DeleteAsync(userId);
        }

        public async Task EditUserAsync(user user)
        {
            await _repository.UpdateAsync(user);
        }

        public async Task<List<user>> GetAllUserAsync()
        {
            return await _repository.GetAllAsync().ToListAsync();
        }

        public Task<user> GetUserAsync(int userId)
        {
            return _repository.GetAsync(userId);
        }

    }
}

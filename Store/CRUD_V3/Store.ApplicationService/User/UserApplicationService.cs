using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Store.Core.User;
using Store.DataAccess.Repositories;
using Store.Dto;
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

        private readonly IMapper _mapper;

        public UserApplicationService(IRepository<int, user> repository , IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

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

        public async Task<List<userDto>> GetAllUserAsync()
        {
            

            var u = await _repository.GetAllAsync().ToListAsync();

            List<userDto> users = _mapper.Map<List<userDto>>(u);

            return users;
        }

        public async Task<userDto> GetUserAsync(int userId)
        {
            var user = await _repository.GetAsync(userId);

            userDto dto = _mapper.Map<userDto>(user);

            return dto;
        }

    }
}

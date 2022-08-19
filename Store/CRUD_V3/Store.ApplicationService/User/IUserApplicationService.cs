using Store.Core.User;
using Store.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationService.User
{
    public interface IUserApplicationService
    {
        Task<List<userDto>> GetAllUserAsync();

        Task<int> AddUserAsync(user user);

        Task DeleteUserAsync(int userId);

        Task<userDto> GetUserAsync(int userId);

        Task EditUserAsync(user user);
        
    }
}

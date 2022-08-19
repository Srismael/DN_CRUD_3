using Microsoft.AspNetCore.Mvc;
using Store.ApplicationService.User;
using Store.Core.User;
using Store.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        private readonly IUserApplicationService _manager;

        public UserController(IUserApplicationService manager)
        {
            _manager = manager;

        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<userDto>> Get()
        {
            return await _manager.GetAllUserAsync();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<userDto> Get(int id)
        {
            return await _manager.GetUserAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task Post([FromBody] user user)
        {
            await _manager.AddUserAsync(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] user user)
        {
            user.Id = id;
            await _manager.EditUserAsync(user);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _manager.DeleteUserAsync(id);
        }
    }
}

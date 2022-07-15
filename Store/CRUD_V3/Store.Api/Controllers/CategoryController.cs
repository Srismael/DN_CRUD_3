using Microsoft.AspNetCore.Mvc;
using Store.ApplicationService.Category;
using Store.Core.Inventories;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryApplicationService _manager;


        public CategoryController(ICategoryApplicationService manager)
        {
            _manager = manager;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IEnumerable<category>> Get()
        {
            return await _manager.GetAllCategoryAsync();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<category> Get(int id)
        {
            return await _manager.GetCategoryAsync(id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task Post([FromBody] category category)
        {
            await _manager.AddCategoryAsync(category);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] category category)
        {
            category.Id = id;
            await _manager.EditCategoryAsync(category);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _manager.DeleteCategoryAsync(id);
        }
    }
}

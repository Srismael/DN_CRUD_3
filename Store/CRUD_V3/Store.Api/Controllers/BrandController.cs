using Microsoft.AspNetCore.Mvc;
using Store.ApplicationService.Brand;
using Store.Core.Inventories;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandApplicationService _manager;

        public BrandController(IBrandApplicationService manager)
        {
            _manager = manager;

        }

        // GET: api/<BrandController>
        [HttpGet]
        public async Task<IEnumerable<brand>> Get()
        {
            return await _manager.GetAllBrandAsync();
        }

        // GET api/<BrandController>/5
        [HttpGet("{id}")]
        public async Task<brand> Get(int id)
        {
            var brand = await _manager.GetBrandAsync(id);
            return brand;
        }

        // POST api/<BrandController>
        [HttpPost]
        public async Task Post([FromBody] brand brand)
        {
            await _manager.AddBrandAsync(brand);
        }

        // PUT api/<BrandController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] brand brand)
        {
            brand.Id = id;
            await _manager.EditBrandAsync(brand);
        }

        // DELETE api/<BrandController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _manager.DeleteBrandAsync(id);
        }
    }
}

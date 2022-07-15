using Microsoft.AspNetCore.Mvc;
using Store.ApplicationService.Product;
using Store.Core.Inventories;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplicationService _manager;

        public ProductController(IProductApplicationService manager)
        {
            _manager = manager;

        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<product>> Get()
        {
            return await _manager.GetAllProductAsync();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<product> Get(int id)
        {

            return await _manager.GetProductAsync(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task Post([FromBody] product product)
        {
            await _manager.AddProductAsync(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] product product)
        {
            product.Id = id;
            await _manager.EditProductAsync(product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _manager.DeleteProductAsync(id);
        }
    }
}

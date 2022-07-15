using Microsoft.AspNetCore.Mvc;
using Store.ApplicationService.Sale;
using Store.Core.Sale;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleApplicationService _manager;

        

        public SaleController(ISaleApplicationService manager)
        {
            _manager = manager;

        }
        // GET: api/<SaleController>
        [HttpGet]
        public async Task<IEnumerable<sale>> Get()
        {
            return await _manager.GetAllSaleAsync();
        }

        // GET api/<SaleController>/5
        [HttpGet("{id}")]
        public async Task<sale> Get(int id)
        {
            return await _manager.GetSaleAsync(id);
        }

        // POST api/<SaleController>
        [HttpPost]
        public async Task Post([FromBody] sale sale)
        {
            await _manager.AddSaleAsync(sale);
        }

        // PUT api/<SaleController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] sale sale)
        {
            sale.Id = id;
            await _manager.EditSaleAsync(sale);
        }

        // DELETE api/<SaleController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _manager.DeleteSaleAsync(id);
        }
    }
}

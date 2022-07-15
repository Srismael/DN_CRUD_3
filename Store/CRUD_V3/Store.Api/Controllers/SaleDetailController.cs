using Microsoft.AspNetCore.Mvc;
using Store.ApplicationService.Sale_Detail;
using Store.Core.Sale;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleDetailController : ControllerBase
    {
        private readonly ISaleDetailsApplicationService _manager;

        public SaleDetailController(ISaleDetailsApplicationService manager)
        {
            _manager = manager;

        }

        // GET: api/<SaleDetail>
        [HttpGet]
        public async Task<IEnumerable<sale_detail>> Get()
        {
            return await _manager.GetAllSaleDetailAsync();
        }

        // GET api/<SaleDetail>/5
        [HttpGet("{id}")]
        public async Task<sale_detail> Get(int id)
        {
            return await _manager.GetSaleDetailAsync(id);
        }

        // POST api/<SaleDetail>
        [HttpPost]
        public async Task Post([FromBody] sale_detail sale_detail)
        {
            await _manager.AddSaleDetailAsync(sale_detail);
        }

        // PUT api/<SaleDetail>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] sale_detail sale_detail)
        {
            await _manager.EditSaleDetailAsync(sale_detail);
        }

        // DELETE api/<SaleDetail>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _manager.DeleteSaleDetailAsync(id);
        }
    }
}

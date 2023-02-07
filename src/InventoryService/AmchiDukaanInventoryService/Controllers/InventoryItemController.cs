using AmchiDukaanInventoryService.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmchiDukaanInventoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryItemController : ControllerBase
    {
        // GET: api/<InventoryItemController>
        [HttpGet]
        public IEnumerable<InventoryItem[]> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<InventoryItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InventoryItemController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InventoryItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InventoryItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

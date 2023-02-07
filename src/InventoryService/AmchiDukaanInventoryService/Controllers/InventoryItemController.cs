using AmchiDukaanInventoryService.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmchiDukaanInventoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryItemController : ControllerBase
    {
        private static readonly InventoryItem mockInventoryItem = new()
        {
            product = new Product
            {
                productId = "p1",
                productName = "Orange",
                productDescription = "Orange fruit",
                productCategory = "Fruit",
                productType = "Consumable"
            },
            inventory = new Inventory()
            {
                inventoryId = "i1",
                location = "Gujrat"
            },
            countOfItem= 10,
        };
        private static readonly InventoryItem mockInventoryItem1 = new()
        {
            product = new Product
            {
                productId = "p2",
                productName = "Banana",
                productDescription = "Yellow fruit",
                productCategory = "Fruit",
                productType = "Consumable"
            },
            inventory = new Inventory()
            {
                inventoryId = "i1",
                location = "Gujrat"
            },
            countOfItem=112
        };
        private readonly InventoryItem[] mockGurjatInventory = new InventoryItem[] {
            mockInventoryItem,
            mockInventoryItem1
        };
        // GET: api/<InventoryItemController>/inventoryId
        [HttpGet]
        [Route("getItemsInInventory")]
        public InventoryItem[] GetItemsInInventory(string inventoryId)
        {
            switch (inventoryId)
            {
                case "gujrat":
                    return mockGurjatInventory;
                default:
                    return new InventoryItem[] { };
            }
        }

        // GET: api/<InventoryItemController>/
        [HttpGet]
        [Route("api/")]
        public int GetProductCountInInventory(Guid inventoryId, Guid productId)
        {
            return 2;
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

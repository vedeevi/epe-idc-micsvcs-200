namespace AmchiDukaanInventoryService.Model
{
    public class Product
    {
        public Guid productId { get; set; }
        public string productName { get; set; } = string.Empty;

        public string productDescription { get; set; }

        public string productCategory { get; set; }
        public string productType { get; set; }
    }
}

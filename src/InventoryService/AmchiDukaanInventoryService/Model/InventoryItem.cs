namespace AmchiDukaanInventoryService.Model
{
    public class InventoryItem
    {
        public Product product { get; set; }
        public Inventory inventory { get; set; }
        public int countOfItem { get; set; }

    }
}

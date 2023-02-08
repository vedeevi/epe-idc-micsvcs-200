
namespace ProductService.Models
{
		public class Product
		{
			public Guid Id { get; set; }
			public string Title { get; set; } = string.Empty;
			public string Imageurl { get; set; } = string.Empty;
			public string Description { get; set; } = string.Empty;
			public Specification Product_Specification { get; set; } = new Specification();
		    public Double Price { get; set; }
		}
}

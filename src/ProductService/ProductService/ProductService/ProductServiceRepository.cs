
using ProductService.Models;

namespace ProductService
{
	public class ProductServiceRepository : IProductServiceRepository
	{
		private static List<Product> products;

		public ProductServiceRepository()
		{
			products = new List<Product>();
			initialize();
		}

		public List<Product> GetAllProducts()
		{
			return products;
		}

		public void AddProduct(Product requestPayload)
		{
			requestPayload.Id = Guid.NewGuid();
			products.Add(requestPayload);
		}
		public void initialize()
		{
			products.Add(
				new Product
				{
					Id = Guid.NewGuid(),
					Title = "Product A",
					Imageurl = "",
					Description = "Product A",
					Product_Specification = new Specification
					{
						weight = "500gm",
						Country = "INDIA",
					},
					Price = 10.0
				});
			products.Add(
			new Product
			{
				Id = Guid.NewGuid(),
				Title = "Product B",
				Imageurl = "",
				Description ="Product B",
				Product_Specification =  new Specification
				{
					weight= "200gm",
					Country = "INDIA",
				},
				Price = 10.0
			});
		}
	}
}

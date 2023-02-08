
using ProductService.Models;

namespace ProductService
{
	public interface IProductServiceRepository
	{
		public List<Product> GetAllProducts();

		public void AddProduct(Product requestPayload);

	}
}


using System.Net;
using System.Text.Json;

using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;

using ProductService.Models;

namespace ProductService
{
    public class ProductService
    {
        private readonly ILogger _logger;
		private IProductServiceRepository _repository;
		

        public ProductService(ILoggerFactory loggerFactory,IProductServiceRepository productServiceRepository)
        {
            _logger = loggerFactory.CreateLogger<ProductService>();
			_repository = productServiceRepository;
        }

        [Function("GetAllProducts")]
        public HttpResponseData GetAllProducts([HttpTrigger(AuthorizationLevel.Function, "get", Route = "v1/api/products/")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
			var response = req.CreateResponse(HttpStatusCode.OK);
			try
			{
				
				response.WriteAsJsonAsync(_repository.GetAllProducts()).ConfigureAwait(false);

				return response;
			}
			catch (Exception ex)
			{
				response = req.CreateResponse(HttpStatusCode.InternalServerError);
				return response;
			}
		}

		[Function("AddProduct")]
		public async Task<HttpResponseData> AddProductAsync([HttpTrigger(AuthorizationLevel.Function, "post", Route = "v1/api/product/")] HttpRequestData req)
		{
			_logger.LogInformation("C# HTTP trigger function processed a request.");
			var response = req.CreateResponse(HttpStatusCode.OK);
			try
			{
				Product requestPayload = await JsonSerializer.DeserializeAsync<Product>(req.Body) ?? throw new ArgumentException();
			   _repository.AddProduct(requestPayload);

				return response;
			}
			catch (Exception ex)
			{
				response = req.CreateResponse(HttpStatusCode.InternalServerError);
				return response;
			}
		}

	}
}

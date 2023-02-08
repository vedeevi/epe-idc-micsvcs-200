using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ProductService
{
	[ExcludeFromCodeCoverage]
	public class Program
	{
		public static void Main()
		{
			IHost? host = new HostBuilder()
			.ConfigureFunctionsWorkerDefaults()
			.ConfigureServices((hostBuilderContext, services) => ConfigureServices(services))
			.Build();

			host.Run();
		}

		private static void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<IProductServiceRepository, ProductServiceRepository>();
		}
	}
}
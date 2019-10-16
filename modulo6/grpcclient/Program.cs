using System;
using System.Threading.Tasks;
using curso;
using Grpc.Net.Client;

namespace grpcclient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var productId = args != null && args.Length > 0 && int.TryParse(args[0], out int value) ? value : 1;

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ProductsService.ProductsServiceClient(channel);
            var request = new ProductRequest(){ Id = productId};
            var result = await client.GetProductByIdAsync(request);

            Console.WriteLine($"{result.Id} {result.Name} {result.Price} {result.IsAvailable} {result.Category}");

            Console.ReadKey();
        }
    }
}

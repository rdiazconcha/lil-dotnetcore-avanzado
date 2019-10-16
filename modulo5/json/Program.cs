using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace json
{
class Product {
     public int Id { get; set; }
     public string Name { get; set; }
     public decimal Price { get; set; }
     public Category Category { get; set; }
 }

 enum Category {
     Food,
     Technology
 }


    class Program
    {
        static async Task Main(string[] args)
        {
            var products = new List<Product>();
            products.Add(new Product(){ Id = 1, Name = "Chocolate", Price = 2, Category = Category.Food});
            products.Add(new Product(){ Id = 2, Name = "Mouse", Price = 10, Category = Category.Technology});
            
            var result = JsonSerializer.Serialize(products);

            var deserializedProducts = JsonSerializer.Deserialize<IEnumerable<Product>>(result);



            Console.WriteLine(result);

            using var stream = File.OpenRead("volcanodata.json");
            var doc = await JsonDocument.ParseAsync(stream);

            Console.WriteLine(doc.RootElement);
        }
    }
}

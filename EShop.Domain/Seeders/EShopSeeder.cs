using EShop.Domain.Repositories;
using EShopDomain.Models;

namespace EShop.Domain.Seeders
{
    public class EShopSeeder(DataContext context) : IEShopSeeder
    {
        public async Task Seed()
        {
            if (!context.Products.Any())
            {
                var students = new List<Product>
                {
                    new Product { Name = "Mango", Ean = "113243442" },
                    new Product { Name = "Apple", Ean = "4321431" },
                    new Product { Name = "Banana", Ean = "12213122" }
                };

                context.Products.AddRange(students);
                context.SaveChanges();
            }
        }
    }
}
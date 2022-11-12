using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceGenerationSystem.Entities;
using InvoiceGenerationSystem.Services;

namespace InvoiceGenerationSystem.Repositories
{
    public class ProductsRepository
    {
        private CsvService service = new CsvService();

        public static List<Product> Products { get; set; } = new List<Product>();

        public ProductsRepository()
        {
            Products = service.ReadProductsCreateObjects();
        }

        public static void ListProducts()
        {
            Console.WriteLine("-----------List of Items--------------\n");

            foreach (var product in Products)


            {
                var index = Products.IndexOf(product);
                Console.WriteLine( index +1 + ". Pavadinimas: " + product.ProductName + " Kaina Eur: " + product.ProductPrice);
            }
            Console.WriteLine("\n---------------End--------------");
        }
    }
}

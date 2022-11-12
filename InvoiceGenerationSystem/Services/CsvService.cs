using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceGenerationSystem.Entities;

namespace InvoiceGenerationSystem.Services
{
    public class CsvService
    {
        private string ProductsPath = "C:\\Users\\kazgr\\Desktop\\VIko\\0. VIGI programavimo kursai\\4. C#\\InvoiceGenerationSystem\\InvoiceGenerationSystem\\Data\\Products.csv";


        public List<Product> ReadProductsCreateObjects()
        {
            string csvfile = File.ReadAllText(ProductsPath);
            string[] lines = csvfile.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var products = new List<Product>();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] productDataArray = lines[i].Split(',');

                var product = new Product(productDataArray[0], Convert.ToDouble(productDataArray[1]));
                products.Add(product);
            }
            return products;
        }
            
        
    }
}

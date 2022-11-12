using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerationSystem.Entities
{
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Product(string productName, double productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }
    }
}

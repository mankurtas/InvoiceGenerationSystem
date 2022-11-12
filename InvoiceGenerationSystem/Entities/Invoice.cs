using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerationSystem.Entities
{
    public class Invoice
    {
        public string InvoiceNumber { get; set; }
        public string IssueDate { get; set; }

        public double TotalPrice { get; set; }

        public List<string> Products { get; set; } = new List<string>();

        public Invoice(string invoiceNumber, string issueDate)
        {
            InvoiceNumber = invoiceNumber;
            IssueDate = issueDate;
            
        }

        public void AddProductToInvoice(string product, double price)
        {
            Products.Add(product);
            TotalPrice += price;
        }
        public void ListInvoiceInformation()
        {
            Console.WriteLine("Invoice number " + InvoiceNumber + " Issued Time: " + IssueDate);
            foreach (var product in Products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("Total price Eur: " + TotalPrice);
        }
        public string[] InvoiceInformation()
        {
            string[] invoice = new string[] { "Invoice Report", "Invoice number " + InvoiceNumber + " Issued Time: " + IssueDate };

            int index = 1;
            foreach (var product in Products)
            {


                invoice = invoice.Append(product).ToArray();

                index++;
            }

            invoice = invoice.Append("Total price Eur: " + TotalPrice).ToArray();

            return invoice;
        }
    }
}

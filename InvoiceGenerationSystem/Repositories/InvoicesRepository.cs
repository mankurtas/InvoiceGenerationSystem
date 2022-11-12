using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using InvoiceGenerationSystem.Entities;

namespace InvoiceGenerationSystem.Repositories
{
    public class InvoicesRepository
    {
        public static List<Invoice> Invoices = new List<Invoice>();

        public static void AddInvoice(Invoice item)
        {
            Invoices.Add(item);
        }

        public static void ListOfGeneratedInvoices()
        {
            int index = 1;
            foreach (var invoice in Invoices)
            {
                Console.WriteLine(index + ". " + invoice.InvoiceNumber + " Issue Date: " + invoice.IssueDate + " Total Price: " + invoice.TotalPrice);
                index++;
            }
            Console.WriteLine("Total all invoices price Eur: " + TotalPriceAllInvoices());
        }
        public static double TotalPriceAllInvoices()
        {
            double total = 0;

            foreach (var invoice in Invoices)
            {
                total +=invoice.TotalPrice;
            }
                
            return total;
        }

        public static string[] ListOfGeneratedInvoicesArrayForFile()
        {
            string[] invoices = new string[] {"Generated Invoices Report"};

            int index = 1;
            foreach (var invoice in Invoices)
            {
                

                invoices = invoices.Append(index + ". " + invoice.InvoiceNumber + " Issue Date: " + invoice.IssueDate + " Total Price: " + invoice.TotalPrice).ToArray();
                                
                index++;
            }

            invoices = invoices.Append("Total price of all invoices Eur: " + TotalPriceAllInvoices()).ToArray();

            return invoices;
        }

    }
}

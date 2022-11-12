using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceGenerationSystem.Entities;
using InvoiceGenerationSystem.Repositories;

namespace InvoiceGenerationSystem.Services
{
    public class GenerateNewInvoice
    {
        public static Invoice GenerateInvoce()

        {
            Console.WriteLine("Enter invoice number");
            string invoiceNumber = Console.ReadLine();
            Console.WriteLine("Issue date: ");
            string issuedate = Console.ReadLine();

            var invoice = new Invoice(invoiceNumber, issuedate);

            
            ProductsRepository.ListProducts();

           

            Console.WriteLine("Choose product from lits to add in invoice");
            Console.WriteLine("0. Back to Main Menu");
            int index = 1;
            int selection = GetSelectionService.GetSelectionValidationForInteger();

            while(selection != 0)
            {
                if(selection == -1)
                {
                    Console.WriteLine("Wrong input format, select number \n");
                    selection = GetSelectionService.GetSelectionValidationForInteger();
                }
                else if (selection > ProductsRepository.Products.LongCount() || selection < 1)
                {
                    Console.WriteLine("Selected item out of range, please select item from list.\n");
                    selection = GetSelectionService.GetSelectionValidationForInteger();
                }
                else
                {
                    invoice.AddProductToInvoice(index + ". "+ ProductsRepository.Products[selection-1].ProductName + " Kaina Eur: " + ProductsRepository.Products[selection-1].ProductPrice, ProductsRepository.Products[selection - 1].ProductPrice);
                    index++;
                    Console.WriteLine("Please add more or go back to Main Menu.\n");
                    selection = GetSelectionService.GetSelectionValidationForInteger();
                }
            }

            InvoicesRepository.AddInvoice(invoice);
                        
            return invoice;

        }

    }
}

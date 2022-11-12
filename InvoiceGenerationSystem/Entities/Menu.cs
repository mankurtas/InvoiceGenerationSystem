using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceGenerationSystem.Repositories;
using InvoiceGenerationSystem.Services;

namespace InvoiceGenerationSystem.Entities
{
    public class Menu
    {
        public void InitiateMenu() {
            bool isActive = true;

            while (isActive)
            {
                Console.WriteLine("\n ______________________________________\n");
                Console.WriteLine("1. Generate New Invoice");
                Console.WriteLine("2. List Generated Invoices and save report");
                Console.WriteLine("3. Check particular invoice and save to file");
                
                Console.WriteLine("5. Exit");
                Console.WriteLine("______________________________________\n");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        GenerateNewInvoice.GenerateInvoce();
                    break;
                    case "2":

                        var invoices = InvoicesRepository.Invoices;

                        if (invoices.Count == 0) {
                            Console.WriteLine("Nil invoices generated, plase generate invoice");
                            
                        }
                        else
                        {

                            InvoicesRepository.ListOfGeneratedInvoices();


                            bool isActive2 = true;

                            while (isActive2)
                            {
                                Console.WriteLine("\n ______________________________________\n");
                                Console.WriteLine("1. Save report to file");
                                Console.WriteLine("0. Back to Main Menu");
                                Console.WriteLine("______________________________________\n");
                                option = Console.ReadLine();
                                switch (option)
                                {
                                    case "1":
                                        SaveReportService.SaveReportToFile();
                                        break;
                                    case "0":
                                        isActive2 = false;
                                        break;
                                    default:
                                        Console.WriteLine("Incorect input");
                                        break;
                                }

                            }
                            

                        }
                        
                        
                    break;
                    case "3":
                        var invoices1 = InvoicesRepository.Invoices;
                        if (invoices1.Count == 0)
                        {
                            Console.WriteLine("Nil invoices generated, plase generate invoice");

                        }
                        else
                        {
                            InvoicesRepository.ListOfGeneratedInvoices();
                            bool isActive3 = true;

                            while (isActive3)
                            {
                                Console.WriteLine("\n ______________________________________\n");
                                Console.WriteLine("1. Select invoice for Details");
                                Console.WriteLine("0. Back to Main Menu");
                                Console.WriteLine("______________________________________\n");
                                int selection = GetSelectionService.GetSelectionValidationForInteger();


                                while (selection != 0)
                                {
                                    
                                    if(selection == -1 || selection > invoices1.Count())
                                    {
                                        Console.WriteLine("Worng input or ourt of rannge");
                                        selection = GetSelectionService.GetSelectionValidationForInteger();
                                    }
                                    else
                                    {
                                        invoices1[selection - 1].ListInvoiceInformation();
                                        bool isActive4 = true;

                                        while (isActive4)
                                        {
                                            Console.WriteLine("\n ______________________________________\n");
                                            Console.WriteLine("1. Save invoice to file");
                                            Console.WriteLine("0. Back to Main Menu");
                                            Console.WriteLine("______________________________________\n");
                                            var option1 = Console.ReadLine();
                                            switch (option1)
                                            {
                                                case "1":
                                                    SaveInvoiceService.SaveInvoice(invoices1[selection-1]);
                                                    break;
                                                case "0":
                                                    isActive4 = false;
                                                    selection = 0;
                                                    break;
                                                default:
                                                    Console.WriteLine("Incorect input");
                                                    break;
                                            }
                                            
                                        }
                                        
                                    }



                                }
                                isActive3 = false;
                                

                            }



                        }
                            break;
                    case "5":
                        isActive = false;
                        break;
                        default:
                        Console.WriteLine("Incorrect input");
                        break;


                }
            }
        }
    }
}

using System.IO;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceGenerationSystem.Entities;

namespace InvoiceGenerationSystem.Services
{
    public class SaveInvoiceService
    {
       
        public static void SaveInvoice(Invoice item)
        {
            string path = "C:\\Users\\kazgr\\Desktop\\VIko\\0. VIGI programavimo kursai\\4. C#\\InvoiceGenerationSystem\\InvoiceGenerationSystem\\InvoiceFile\\";
            string invoice = path + item.InvoiceNumber + ".txt";
            

            if (!File.Exists(invoice))
            {
                File.WriteAllLines(invoice, item.InvoiceInformation());
            }
            else
            {
                Console.WriteLine("Invoice alreaady saved!");
            }

        }

    }
}

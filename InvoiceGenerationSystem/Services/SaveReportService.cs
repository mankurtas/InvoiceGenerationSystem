using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceGenerationSystem.Entities;
using InvoiceGenerationSystem.Repositories;

namespace InvoiceGenerationSystem.Services
{
    public class SaveReportService
    {
        public static void SaveReportToFile()
        {
            string folder = "C:\\Users\\kazgr\\Desktop\\VIko\\0. VIGI programavimo kursai\\4. C#\\InvoiceGenerationSystem\\InvoiceGenerationSystem\\InvoicesReport\\";
            string fileName = "GeneratedInvoicesReport.txt";
            string fullPath = folder + fileName;

            string[] invoicesReport = InvoicesRepository.ListOfGeneratedInvoicesArrayForFile();

            File.WriteAllLines(fullPath, invoicesReport);

        }
       
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using InvoiceGenerationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerationSystem.Entities.Tests
{
    [TestClass()]
    public class InvoiceTests
    {
        [TestMethod()]
        public void InvoiceInformationTest()
        {

            Invoice newinvoice = new Invoice("Lt500", "2022");
           string[] result = {"Invoice Report", "Invoice number Lt500 Issued Time: 2022", "Total price Eur: 0" };
        
            Assert.Equals(result, newinvoice.InvoiceInformation());
            
            

            
        }
    }
}
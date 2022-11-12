using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerationSystem.Services
{
    public class GetSelectionService
    {
        public static int GetSelectionValidationForInteger()
        {

            bool isSuccess = Int32.TryParse(Console.ReadLine(), out int result);

            if (isSuccess)
            {
                return result;
            }
            else
            {
                return -1;
            }

        }
    }
}

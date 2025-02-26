using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleAssignment2_Functions.Printer
{
    public class PlainTextPrinter : IPrinter
    {
        public void PrintPage(string page)
        {
            try
            {
                Console.WriteLine(page);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

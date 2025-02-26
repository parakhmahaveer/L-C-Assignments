using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleAssignment2_Functions.Printer
{
    public class HtmlPrinter : IPrinter
    {
        public void PrintPage(string page)
        {
            try
            {
                Console.WriteLine($"<div style='single-page'>{page}</div>");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

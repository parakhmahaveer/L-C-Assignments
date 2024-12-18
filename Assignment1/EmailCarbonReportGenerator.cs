using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class EmailCarbonReportGenerator
    {
        // Method to display the carbon footprint report
        public static void DisplayCarbonFootprint(string mailSource, EmailInfo emailInfo)
        {
            if (mailSource == "email")
            {
                var folderSizes = new Dictionary<EmailType, double>
                {
                    { EmailType.Long, emailInfo.InboxFolderSize },
                    { EmailType.Short, emailInfo.InboxFolderSize },
                    { EmailType.Sent, emailInfo.SentFolderSize },
                    { EmailType.Spam, emailInfo.SpamFolderSize }
                };
                double longFolderCarbonAmount = CarbonFootprintCalculator.CalculateCarbonAmount(emailInfo.InboxFolderSize, EmailType.Long);
                double shortFolderCarbonAmount = CarbonFootprintCalculator.CalculateCarbonAmount(emailInfo.InboxFolderSize, EmailType.Short);
                double sentFolderCarbonAmount = CarbonFootprintCalculator.CalculateCarbonAmount(emailInfo.SentFolderSize, EmailType.Sent);
                double spamFolderCarbonAmount = CarbonFootprintCalculator.CalculateCarbonAmount(emailInfo.SpamFolderSize, EmailType.Spam);

                Console.WriteLine(mailSource);
                Console.WriteLine($"emailId : {emailInfo.EmailId}");
                Console.WriteLine($"source: {emailInfo.EmailSource}");
                Console.WriteLine($"inbox : {longFolderCarbonAmount + shortFolderCarbonAmount} KG");
                Console.WriteLine($"sent : {sentFolderCarbonAmount} KG");
                Console.WriteLine($"spam : {spamFolderCarbonAmount} KG");
            }
        }
    }
}

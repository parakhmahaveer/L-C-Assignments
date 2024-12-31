namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailInfo = new EmailInfo
            {
                EmailId = "mahaveer.parakh@intimetec.com",
                EmailSource = "outlook",
                InboxFolderSize = 75.0,
                SentFolderSize = 10.0,
                SpamFolderSize = 10.0
            };

            // Call the method to display carbon footprint report
            EmailCarbonReportGenerator.DisplayCarbonFootprint("email", emailInfo);
        }
    }
}

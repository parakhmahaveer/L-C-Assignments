using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class CarbonFootprintCalculator
    {
        //Email size per KG
        private const double LongEmailCarbonSize = 17.00;
        private const double ShortEmailCarbonSize = 0.02;
        private const double SentEmailCarbonSize = 0.05;
        private const double SpamEmailCarbonSize = 0.03;

        // Method to calculate the carbon amount
        public static double CalculateCarbonAmount(double emailFolderSize, EmailType category)
        {
            switch (category)
            {
                case EmailType.Long:
                    return LongEmailCarbonSize * emailFolderSize;
                case EmailType.Short:
                    return ShortEmailCarbonSize * emailFolderSize;
                case EmailType.Sent:
                    return SentEmailCarbonSize * emailFolderSize;
                case EmailType.Spam:
                    return SpamEmailCarbonSize * emailFolderSize;
                default:
                    return 0;
            }
        }
    }
}

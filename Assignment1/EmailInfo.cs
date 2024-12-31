using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class EmailInfo
    {
        public string EmailId { get; set; } = null!;
        public string EmailSource { get; set; } = null!;
        public double InboxFolderSize { get; set; }
        public double SentFolderSize { get; set; }
        public double SpamFolderSize { get; set; }
    }
}

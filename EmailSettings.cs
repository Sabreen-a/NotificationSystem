using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class EmailSettings
    {

        public string SmtpServer { get; set; }
        public int  SmtpPort { get; set; }
        public string EmailFrom { get; set; }
        public string AppPassword { get; set; }
        public string EmailTo { get; set; }


       
    }
}

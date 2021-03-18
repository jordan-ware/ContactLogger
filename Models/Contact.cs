using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLogs.Models
{
    public class Contact
    {
        public long ContactId { get; set; }
        public long StudentId { get; set; }
        public DateTime ContactDate { get; set; }
        public string ContactNotes { get; set; }
        
    }
}

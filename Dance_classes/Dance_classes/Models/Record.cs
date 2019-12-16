using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dance_classes.Models
{
    public class Record
    {
        public int RecordId { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public int DanceId { get; set; }
    }
}
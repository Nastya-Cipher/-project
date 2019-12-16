using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dance_classes.Models
{
    public class Dance
    {
        public int Id { get; set; }
        public string TypeOfDance { get; set; }
        public string Treiner { get; set; }
        public int Price { get; set; }
    }
}
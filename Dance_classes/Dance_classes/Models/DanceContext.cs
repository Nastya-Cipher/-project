using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Dance_classes.Models
{
    public class DanceContext:DbContext
    {
        public DbSet<Dance> Dances { get; set; }
        public DbSet<Record> Records { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Dance_classes.Models
{
    public class DanceDbInitializer : DropCreateDatabaseAlways<DanceContext>
    {
        protected override void Seed(DanceContext db)
        {
            db.Dances.Add(new Dance { TypeOfDance = "Хип хоп", Treiner = "Усенко", Price = 3000 });
            db.Dances.Add(new Dance { TypeOfDance = "Балет", Treiner = "Франскевич", Price = 4000 });
            db.Dances.Add(new Dance { TypeOfDance = "Эстрада", Treiner = "Шарапова", Price = 6000 });

            base.Seed(db);
        }
      
    }
}
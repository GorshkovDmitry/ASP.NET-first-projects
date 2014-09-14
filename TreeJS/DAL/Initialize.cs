using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TreeJS.Models;
using TreeJS.DAL;

namespace TreeJS.DAL
{
    public class Initialize : DropCreateDatabaseIfModelChanges<DBForDNSContext>
    {
        protected override void Seed(DBForDNSContext context)
        {
            var file = new List<File> 
            { 
                new File { Name = "AbstractContainer.js", PathID = 8, type = "File"},
                new File { Name = "ButtonGroup.js", PathID = 8, type = "File"},
                new File { Name = "Container.js", PathID = 8, type = "File"},
                new File { Name = "DockingContainer.js", PathID = 9, type = "File"},
                new File { Name = "Monitor.js", PathID = 9, type = "File"},
                new File { Name = "Viewport.js", PathID = 9, type = "File"}
            };
            file.ForEach(s => context.Files.Add(s));
            context.SaveChanges();

            var path = new List<File> 
            { 
                new File { Name = "Ext JS" },
                new File { Name = "class", PathID = 7 },
                new File { Name = "container", PathID = 7 },
                new File { Name = "chart", PathID = 7 },
                new File { Name = "data", PathID = 7 },
                new File { Name = "dd", PathID = 7 },
                new File { Name = "diag", PathID = 7 }
            };
            path.ForEach(s => context.Files.Add(s));
            context.SaveChanges();

           
        }
    }
}
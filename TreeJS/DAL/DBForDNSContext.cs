using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TreeJS.Models;

namespace TreeJS.DAL
{
    public class DBForDNSContext : DbContext
    {
        public DbSet<File> Files { get; set; }

    }
}
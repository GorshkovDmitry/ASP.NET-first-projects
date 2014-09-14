using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreeJS.Models
{
    public class File
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string type { set; get; }
        public int? PathID { set; get; }
        public IList<File> Files { set; get; }
        
        public File()
        {
            Files = new List<File>();
        }
    }
}
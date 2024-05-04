using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Laptop : Product
    {
        public string processor {  get; set; }
        public string ram { get; set; } 
        public string os { get; set; }
        public string screen { get; set; }
        public string hdd { get; set; }
        public string graphicCard { get; set; }
        public string batterry { get; set; }


    }
}

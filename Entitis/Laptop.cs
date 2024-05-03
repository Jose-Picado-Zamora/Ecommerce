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
        public char RAM { get; set; }
        public string OS { get; set; }
        public string screen { get; set; }
        public char HDD { get; set; }
        public char graphic_card { get; set; }
        public char batterry { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Address
    {
        public string country { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string street { get; set; }
        public int postalCode { get; set; }
    }
}

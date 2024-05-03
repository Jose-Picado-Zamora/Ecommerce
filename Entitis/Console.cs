using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Console : Product
    {
        public string brand { get; set; }
        public string model { get; set; }
        public string storage { get; set; }
        public bool portable { get; set; }
        public string conectivity { get; set; }
    }
}

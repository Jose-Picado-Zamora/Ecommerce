using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Smarthphone : Product
    {
        public string model { get; set; }
        public string camera { get; set; }
        public string memory { get; set; }
        public int battery { get; set; }
        public string color{ get; set; }
        public string system { get; set; }

    }
}

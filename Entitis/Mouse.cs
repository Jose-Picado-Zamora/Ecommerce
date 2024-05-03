using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Mouse : Product
    {
        public string connection_type {  get; set; }
        public string scroll_wheel { get; set;}
        public string sensor_resolution { get; set; }
        public string OS_compatibility { get; set; }
        public string size_and_grip { get; set; }
        public string durability { get; set; }
        public string extras { get; set; }



    }
}

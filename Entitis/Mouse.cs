using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Mouse : Product
    {
        public string connectionType {  get; set; }
        public string scrollWheel { get; set;}
        public string sensorResolution { get; set; }
        public string osCompatibility { get; set; }
        public string sizeAndGrip { get; set; }
        public string durability { get; set; }
        public string extras { get; set; }



    }
}

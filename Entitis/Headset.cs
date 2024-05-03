using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Headset : Product
    {
        public string microphone {  get; set; }
        public string conectivity { get; set; }
        public bool activeNoiseCancelling { get; set; }
        public int battery  { get; set; }

    }
}

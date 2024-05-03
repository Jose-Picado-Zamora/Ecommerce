using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Card
    {
        public string type {  get; set; }
        public string globalNetwork { get; set; }
        public string name { get; set; }
        public string acountNumber { get; set; }
        public string expirationDate { get; set; }
        public int CVV { get; set; }

    }
}

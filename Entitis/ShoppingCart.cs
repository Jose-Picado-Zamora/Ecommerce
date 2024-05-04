using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ShoppingCart
    {
        public int userId {  get; set; }
        public double total { get; set; }
        public List<Detail> details { get; set; }
}
}

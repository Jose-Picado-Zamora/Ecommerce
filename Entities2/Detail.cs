using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Detail
    {
        int id;
        public int productId { get; set; }
        public int quantity { get; set; }
        public int subtotal { get; set; }
        public Product? product { get; set; }

    }
}

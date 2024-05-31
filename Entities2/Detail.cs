using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Detail
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public double? subtotal { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int BillId { get; set; }
        public Bill? Bill { get; set; }
    }
}

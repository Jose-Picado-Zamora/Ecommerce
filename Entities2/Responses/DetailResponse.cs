using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DetailResponse
    {
        public int quantity { get; set; }
        public double? subtotal { get; set; } = 0;
        public int ProductId { get; set; }
        public ProductResponseDetail Product { get; set; }
    }
}

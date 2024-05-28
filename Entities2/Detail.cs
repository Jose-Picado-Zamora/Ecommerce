using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Detail
    {
        int id { get; set; }
        public int ProductId { get; set; }
        public int quantity { get; set; }
        public int subtotal { get; set; }
        public Product? product { get; set; }

        [ForeignKey("BillId")]
        public int BillId { get; set; }
        public Bill? Bill { get; set; }

    }
}

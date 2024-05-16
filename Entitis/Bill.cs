using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bill
    {
        public int id {  get; set; }
        public int userId { get; set; }
        public string datetime { get; set; }
        public string paymentMethod { get; set; }
        public List<Detail> Details { get; set; }
    }
}

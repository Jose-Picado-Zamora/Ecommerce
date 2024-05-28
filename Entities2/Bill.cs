using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bill
    {
        public int id {  get; set; }
        public string datetime { get; set; }
        public string paymentMethod { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        [NotMapped] 
        public List<Detail>? Details { get; set; }
    }
}

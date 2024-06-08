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
        public string date { get; set; }
        public string paymentMethod { get; set; }
        public double? total { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public List<Detail>? Details { get; set; }
    }
}

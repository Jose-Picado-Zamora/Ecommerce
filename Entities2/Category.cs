using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        [NotMapped]
        public List<Product>? Products { get; set; }

    }
}

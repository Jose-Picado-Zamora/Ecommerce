using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {

        public  int id {  get; set; }
        public string name { get; set; }
        public double  price { get; set; }
        public string   description {  get; set; }
        public int inStock { get; set; }
        public int CategoryId {  get; set; }
        public string brand { get; set; }
        
        public Category? Category { get; set; }
    }
}

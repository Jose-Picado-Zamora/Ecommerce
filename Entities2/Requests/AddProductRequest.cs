

namespace Entities
{
    public class AddProductRequest
    {
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
        public int inStock { get; set; }
        public int CategoryId { get; set; }
    }
}

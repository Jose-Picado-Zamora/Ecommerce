using Entities;

namespace Services
{
    public interface IsVProduct
    {
        public Product AddProduct(Product product);
        public Product DeleteProduct(Product product, int id);
        public Product UpdateProduct(int id);
        public List<Product> GetAllProduct();
        public Product GetProductById(int id);
    }
}


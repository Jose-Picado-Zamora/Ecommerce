using Entities;

namespace Services
{
    public interface ISvProduct
    {
        
        public List<Product> GetAllProduct();
        public Product GetProductById(int id);
        public Product AddProduct(Product product);
        public Product UpdateProduct(int id, Product product);
        public void DeleteProduct(int id);
    }
}

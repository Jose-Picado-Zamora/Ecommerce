using Entities;

namespace Services
{
    public interface IsVCategory
    {
        public Product AddProductToCategory(Product product);
        public Product RemoveProductToCategory(int id);
        List<Category> GetAllCategories();
        public Category GetCategoryById(int id);
    }
}

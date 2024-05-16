using Entities;

namespace Services
{
    public interface IsVCategory
    {
        //READS
        List<Category> GetAllCategories();
        public Category GetCategoryById(int id);

        //Writes
        public Product AddProductToCategory(Category category);
        public Product RemoveProductToCategory(int id);
    }
}

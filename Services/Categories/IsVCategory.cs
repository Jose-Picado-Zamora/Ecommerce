using Entities;

namespace Services
{
    public interface IsVCategory
    {
        //READS
        List<Category> GetAllCategories();
        public Category GetCategoryById(int id);

        //Writes
        public Category AddCategory(Category category);
        public Category UpdateCategory(int id, Category category);
        public void RemoveCategory(int id);
    }
}

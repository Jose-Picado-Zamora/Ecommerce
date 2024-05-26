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

    }
}

using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;

namespace Services.Categories
{
    public class SvCategory : IsVCategory
    {
        private MyContext _myDbContext = default!;
        public SvCategory()
        {
            _myDbContext = new MyContext();
        }
        #region READS 
        public List<Category> GetAllCategories()
        {
            return _myDbContext.Categories.Include(x => x.Products).ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _myDbContext.Categories.Include(x => x.Products).SingleOrDefault(x => x.id == id);
        }
        #endregion

        #region WRITES
        public Category AddCategory(Category category)
        {
            _myDbContext.Categories.Add(category);
            _myDbContext.SaveChanges();

            return category;
        }
        #endregion
    }
}

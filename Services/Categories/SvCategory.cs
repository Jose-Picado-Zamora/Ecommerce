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

        public Category AddProductToCategory(Category category)
        {
            _myDbContext.Categories.Add(category);
            _myDbContext.SaveChanges();

            return category;
        }

        public List<Category> GetAllCategories()
        {
            return _myDbContext.Categories.Include(x => x.Products).ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _myDbContext.Categories.Include(x => x.Products).SingleOrDefault(x => x.id == id);
        }

        public void RemoveProductToCategory(int id)
        {
            Category deleteCategories = _myDbContext.Categories.Find(id);

            if (deleteCategories is not null)
            {
                _myDbContext.Categories.Remove(deleteCategories);
                _myDbContext.SaveChanges();
            }
        }
    }
}

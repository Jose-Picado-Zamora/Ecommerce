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

        public Product AddProductToCategory(Category category)
        {
            _myDbContext.Categories.Add(category);
            _myDbContext.SaveChanges();

            return category;
        }

        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Product RemoveProductToCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Categories;

namespace API_Ecommerce.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private IsVCategory _svCategory;
        public CategoriesController(IsVCategory svCategory)
        {
            _svCategory = svCategory;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _svCategory.GetAllCategories();
        }

        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _svCategory.GetCategoryById(id);
        }

        [HttpPost]
        public void Post([FromBody] AddCategoryRequest categoryRequest)
        {
            Category category = new Category();
            category.name = categoryRequest.name;
            _svCategory.AddCategory(category);
        }

    }
}

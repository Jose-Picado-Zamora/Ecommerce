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

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _svCategory.GetAllCategories();
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _svCategory.GetCategoryById(id);
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Category category)
        {
            _svCategory.AddCategory(category);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category category)
        {
            _svCategory.UpdateCategory(id, new Category
            {
                name = category.name
            });
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void RemoveProductToCategory(int id)
        {
            _svCategory.RemoveCategory(id);
        }
    }
}

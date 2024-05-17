using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Products;

namespace API_Ecommerce.Controllers
{
    public class ProductsController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ProductController : ControllerBase
        {
            private ISvProduct _svProduct;
            public ProductController(ISvProduct svProduct)
            {
                _svProduct = svProduct;
            }

            // GET: api/<BooksController>
            [HttpGet]
            public IEnumerable<Product> Get()
            {
                return _svProduct.GetAllProduct();
            }

            // GET api/<BooksController>/5
            [HttpGet("{id}")]
            public Product Get(int id)
            {
                return _svProduct.GetProductById(id);
            }

            // POST api/<BooksController>
            [HttpPost]
            public void Post([FromBody] Product product)
            {
                _svProduct.AddProduct(product);
            }

            // PUT api/<BooksController>/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] Product product)
            {
                _svProduct.UpdateProduct(id, new Product
                {
                    name = product.name,
                    price = product.price,
                    description = product.description,
                    inStock = product.inStock,
                    CategoryId = product.CategoryId,
                    brand = product.brand,
                });
            }

            // DELETE api/<BooksController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                _svProduct.DeleteProduct(id);
            }
        }
    }
}

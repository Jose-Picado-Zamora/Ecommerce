using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Products;

namespace API_Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private ISvProduct _svProduct;
        public ProductsController(ISvProduct svProduct)
        {
            _svProduct = svProduct;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _svProduct.GetAllProduct();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _svProduct.GetProductById(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _svProduct.AddProduct(product);
        }

        // PUT api/<ProductsController>/5
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

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _svProduct.DeleteProduct(id);
        }
    }

}

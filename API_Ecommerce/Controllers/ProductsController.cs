using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Products;

namespace API_Ecommerce.Controllers
{
    /// <summary>
    /// Represents the response body for retrieving a product.
    /// </summary>
   

  
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
      
        public IEnumerable<ProductResponse> Get()
        {
            List<ProductResponse> productResponses = new List<ProductResponse>();

            foreach (var product in _svProduct.GetAllProduct()) {

                ProductResponse response = new ProductResponse
                {
                    id = product.id,
                    name = product.name,
                    price = product.price,
                    description = product.description,
                    brand = product.brand,
                    inStock = product.inStock,
                    CategoryId = product.CategoryId,
                    CategoryName = product.Category.name

                };
                productResponses?.Add(response);
            }
            return productResponses;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public ProductResponse Get(int id)
        {
            Product product = _svProduct.GetProductById(id);


            // Map the product to the response DTO
            ProductResponse response = new ProductResponse
            {
                id = product.id,
                name = product.name,
                price = product.price,
                description = product.description,
                inStock = product.inStock,
                CategoryId = product.CategoryId,
                brand = product.brand,
                CategoryName = product.Category.name

            };

            return response;
            
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] AddProductRequest productRequest)
        {
            Product product = new Product()
            {
                name = productRequest.name,
                price = productRequest.price,
                brand = productRequest.brand,
                description = productRequest.description,
                inStock = productRequest.inStock,
                CategoryId = productRequest.CategoryId
            };
            
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

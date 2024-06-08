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

        [HttpGet("{id}")]
        public ProductResponse Get(int id)
        {
            Product product = _svProduct.GetProductById(id);

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

        [HttpPost]
        public void Post([FromBody] ProductRequest productRequest)
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

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductRequest product)
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

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _svProduct.DeleteProduct(id);
        }
    }

}

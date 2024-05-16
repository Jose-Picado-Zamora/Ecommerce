using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Products
{
    public class SvProduct : ISvProduct
    {
        private MyContext _myDbContext = default!;
        public SvProduct()
        {
            _myDbContext = new MyContext();
        }

        public List<Product> GetAllProduct()
        {
            return _myDbContext.Products.Include(x => x.Category).ToList();
        }

        public Product GetProductById(int id)
        {
            return _myDbContext.Products.Include(x => x.Category).SingleOrDefault(x => x.id == id);
        }

        public Product AddProduct(Product product)
        {
            _myDbContext.Products.Add(product);
            _myDbContext.SaveChanges();

            return product;
        }

        public Product UpdateProduct(int id, Product product)
        {
            Product productUpdate = _myDbContext.Products.Find(id);
            productUpdate.name = product.name;
            productUpdate.price = product.price;
            productUpdate.description = product.description;
            productUpdate.inStock = product.inStock;
            productUpdate.CategoryId = product.CategoryId;
            productUpdate.brand = product.brand;

            _myDbContext.Update(productUpdate);
            _myDbContext.SaveChanges();

            return product;
        }

        public void DeleteProduct(int id)
        {
            Product deletProduct = _myDbContext.Products.Find(id);

            if (deletProduct is not null)
            {
                _myDbContext.Products.Remove(deletProduct);
                _myDbContext.SaveChanges();
            }
        }

       
       
    }
}
   

    
    

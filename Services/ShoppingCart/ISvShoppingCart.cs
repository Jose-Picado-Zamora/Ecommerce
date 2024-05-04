using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISvShoppingCart
    {
        public Product AddProduct(Product product);
        public Product UpdateProduct(int id, Product product);
        public void DeleteShoppingCart(int id);
        public string BuyConfirmation();
        public double Calculate();


    }
}

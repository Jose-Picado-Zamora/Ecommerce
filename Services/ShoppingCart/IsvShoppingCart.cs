using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IsvShoppingCart
    {
        public ShoppingCart AddAuthor(ShoppingCart shoppingCart);
        public ShoppingCart DeleteShoppingCart(int id);
        public ShoppingCart UpdateShoppingCart(int id, ShoppingCart shoppingCart);
        public string BuyConfirmation();
        public double Calculate();
    }
}

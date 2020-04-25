using System.Collections.Generic;
using System.Linq;
#nullable enable

namespace CashRegister.Repositories
{
    public class ShoppingCartRepository
    {
        private readonly List<ShoppingCart> _shoppingCarts = new List<ShoppingCart>();
        
        public ShoppingCart? Get()
        {
            return _shoppingCarts.FirstOrDefault();
        }

        public void Save(ShoppingCart shoppingCart)
        {
            _shoppingCarts.Add(shoppingCart);
        }
    }
}

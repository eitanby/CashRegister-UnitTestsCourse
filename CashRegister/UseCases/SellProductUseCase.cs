using CashRegister.Exceptions;
using CashRegister.Repositories;
#nullable enable


namespace CashRegister.UseCases
{
    public class SellProductUseCase
    {
        private readonly ProductRepository _products = new ProductRepository();
        private readonly ShoppingCartRepository _shoppingCarts = new ShoppingCartRepository();

        public void SellProduct(string productId)
        {
            var shoppingCart = _shoppingCarts.Get();
            if (shoppingCart == null)
                throw new ShoppingCartNotFound();

            var product = _products.Get(productId);
            if (product == null)
                throw new ProductNotFound(productId);

            shoppingCart.Add(product);

            _shoppingCarts.Save(shoppingCart);
        }
    }
}

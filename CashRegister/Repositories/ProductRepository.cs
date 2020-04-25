using System.Collections.Generic;
#nullable enable


namespace CashRegister
{
    public class ProductRepository
    {
        private readonly Dictionary<string, Product> _products = new Dictionary<string, Product>();

        public Product? Get(string productId)
        {
            if (_products.ContainsKey(productId) == false) return null;
            return _products[productId];
        }

        public void AddOrUpdate(Product product)
        {
            _products[product.Id]=  product;
        }
    }
}
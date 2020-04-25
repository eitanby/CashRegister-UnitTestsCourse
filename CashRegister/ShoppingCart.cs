using System.Collections.Generic;
using System.Linq;
#nullable enable


namespace CashRegister
{
    public class ShoppingCart
    {
        private readonly List<Product> _selectedProducts = new List<Product>();

        public double Total => _selectedProducts.Sum(product => product.Price);

        public void Clear()
        {
            _selectedProducts.Clear();
        }

        public void Add(Product product)
        {
            _selectedProducts.Add(product);
        }

        public IEnumerable<Product> Get(string productId)
        {
            return _selectedProducts.Where(o => o.Id == productId);
        }

        public int NumberOfProducts => _selectedProducts.Count();

    }
}
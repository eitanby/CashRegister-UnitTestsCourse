using CashRegister;
using NUnit.Framework;
using System;
using System.Linq;
#nullable enable

namespace CashRegisterTests
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [Test]
        public void Add_product_to_cart_correctly()
        {
            var product = CreateProduct();
            var cart = new ShoppingCart();

            cart.Add(product);

            Assert.IsTrue(1 == cart.Get(product.Id).Count());
        }

        [Test]
        public void Add_same_product_twice_to_the_cart_correctly()
        {
            var product1 = CreateProduct(productId: "765");
            var product2 = CreateProduct(productId: "765");
            var cart = new ShoppingCart();

            cart.Add(product1);
            cart.Add(product2);

            Assert.IsTrue(2 == cart.Get("765").Count());
        }

        [Test]
        public void Clear_cart_correctly()
        {
            var product = CreateProduct();
            var cart = new ShoppingCart();
            cart.Add(product);

            cart.Clear();

            Assert.IsTrue(0 == cart.NumberOfProducts);
        }

        [TestCase(1, 2, 3, ExpectedResult = 6)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        [TestCase(-1, -2, -3, ExpectedResult = -6)]
        [TestCase(1.1, 2.2, 3.3, ExpectedResult = 6.6)]
        [TestCase(1, -2, 3.1, ExpectedResult = 2.1)]
        public double Claulate_total_correctly(double firstItemPrice, double secondItemPrice, double thirdItemPrice)
        {
            var product1 = CreateProduct(firstItemPrice);
            var product2 = CreateProduct(secondItemPrice);
            var product3 = CreateProduct(thirdItemPrice);

            var cart = new ShoppingCart();

            cart.Add(product1);
            cart.Add(product2);
            cart.Add(product3);

            return cart.Total;
        }

        private Product CreateProduct(double? price = null, string? productId = null)
        {
            if (price == null)
                price = 10;

            return new Product(productId ?? Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString(), price.Value);

        }
    }
}
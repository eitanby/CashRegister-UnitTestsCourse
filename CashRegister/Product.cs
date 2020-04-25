#nullable enable

namespace CashRegister
{
    public class Product
    {
        public Product(string id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public string Id { get; }
        public string Name { get; }
        public double Price { get; }
    }
}
using System;
#nullable enable

namespace CashRegister.Exceptions
{
    public class ProductNotFound : Exception
    {
        public ProductNotFound(string productId) : base($"product id [{productId}] was not found")
        {

        }
    }
}

namespace Ordering.Infrastracture.Data.Extensions;

internal class InitialData
{
    public static IEnumerable<Customer> Customers =>
    new List<Customer>
    {
        Customer.Create(CustomerId.Of(new Guid("58c49479-ec65-4de2-86e7-033c546291aa")), "andrew", "andrew.fly@example.com"),
        Customer.Create(CustomerId.Of(new Guid("6a5d490a-1433-4d72-8a8f-59f8f71a20a0")), "martin", "martin.septim@example.com")
    };

    public static IEnumerable<Product> Products =>
    new List<Product>
    {
        Product.Create(ProductId.Of(new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61")), "Iphone X", 500),
        Product.Create(ProductId.Of(new Guid("b61c2c70-7833-4f9b-b1f8-f7986d2d6ed1")), "MacBook Pro 14-inch", 1999),
        Product.Create(ProductId.Of(new Guid("a35c4876-b285-4b91-baba-3c5b1e2f7473")), "Sony WH-1000XM4", 350),
        Product.Create(ProductId.Of(new Guid("f4e784f1-35c7-41b5-b2df-5e1540e17e62")), "Apple Watch Series 7", 399),
        Product.Create(ProductId.Of(new Guid("2939c275-7d95-4e3b-b890-01f7b19c5c44")), "Dell XPS 15", 1499),
        Product.Create(ProductId.Of(new Guid("dca7c2e6-85a7-482e-81b9-22f1c03e556b")), "Google Nest Hub 2nd Gen", 99),
        Product.Create(ProductId.Of(new Guid("5c6c8f8d-987f-41fb-bf91-9f6d74bfc569")), "Canon EOS R6", 2499),
        Product.Create(ProductId.Of(new Guid("b4e5a9c7-bde6-47ef-9308-9265c3b7b041")), "Nintendo Switch OLED", 349),
        Product.Create(ProductId.Of(new Guid("d65e9fcb-1bde-47f1-b2f8-7985dcd2b98e")), "Dyson V15 Detect", 699)
    };
    
    public static IEnumerable<Order> OrdersWithItems
    {
        get
        {
            var address1 = Address.Of("andrew", "fly", "andrew.fly@example.com", "Gorzelna 12", "Poland", "Zadupcice Dolne", "36369");
            var address2 = Address.Of("martin", "septim", "martin.septim@example.com", "King's Street 1", "Cyrodiil", "Imperial City", "00001");

            var payment1 = Payment.Of("andrew","5555555555554444", "12/28", "355", 1);
            var payment2 = Payment.Of("martin","8888555555554444", "06/30", "222", 2);

            var order1 = Order.Create(
                OrderId.Of(Guid.NewGuid()),
                CustomerId.Of(new Guid("58c49479-ec65-4de2-86e7-033c546291aa")),
                OrderName.Of("Ord_1"),
                shippingAddress: address1,
                billingAddress: address1,
                payment1
            );
            
            order1.Add(ProductId.Of(new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61")), 2, 500);
            order1.Add(ProductId.Of(new Guid("b61c2c70-7833-4f9b-b1f8-f7986d2d6ed1")), 1, 1999);

            var order2 = Order.Create(
                OrderId.Of(Guid.NewGuid()),
                CustomerId.Of(new Guid("6a5d490a-1433-4d72-8a8f-59f8f71a20a0")),
                OrderName.Of("Ord_2"),
                shippingAddress: address2,
                billingAddress: address2,
                payment2
            );
            order2.Add(ProductId.Of(new Guid("f4e784f1-35c7-41b5-b2df-5e1540e17e62")), 1, 399);
            order2.Add(ProductId.Of(new Guid("5c6c8f8d-987f-41fb-bf91-9f6d74bfc569")), 2, 4998);

            return new List<Order> { order1, order2 };
        }
    }
}
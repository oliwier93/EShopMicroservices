namespace Ordering.Infrastracture.Extensions;

internal class InitialData
{
    public static IEnumerable<Customer> Customers =>
    new List<Customer>
    {
        Customer.Create(CustomerId.Of(new Guid("58c49479-ec65-4de2-86e7-033c546291aa")), "andrew", "andrew.fly@example.com"),
        Customer.Create(CustomerId.Of(new Guid("6a5d490a-1433-4d72-8a8f-59f8f71a20a0")), "martin", "martin.septim@example.com")
    };
}
namespace SolidPrinciplesConsoleApp.DependencyInversion;

/// <summary>
/// Order entity
/// </summary>
public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }

    public Order(string customerName, string productName, decimal amount)
    {
        CustomerName = customerName;
        ProductName = productName;
        Amount = amount;
        OrderDate = DateTime.UtcNow;
        Status = OrderStatus.Pending;
    }
}

public enum OrderStatus
{
    Pending,
    Confirmed,
    Shipped,
    Delivered,
    Cancelled
}

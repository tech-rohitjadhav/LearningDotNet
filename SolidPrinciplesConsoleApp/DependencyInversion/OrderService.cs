namespace SolidPrinciplesConsoleApp.DependencyInversion;

/// <summary>
/// Order service - high-level module
/// Dependency Inversion Principle: Depends on abstractions, not concrete implementations
/// </summary>
public class OrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly INotificationService _notificationService;
    private readonly ILogger _logger;

    // Constructor injection - dependencies are injected from outside
    public OrderService(
        IOrderRepository orderRepository,
        INotificationService notificationService,
        ILogger logger)
    {
        _orderRepository = orderRepository;
        _notificationService = notificationService;
        _logger = logger;
    }

    public void CreateOrder(string customerName, string productName, decimal amount, string customerEmail)
    {
        try
        {
            _logger.Log($"Creating order for {customerName}");
            
            var order = new Order(customerName, productName, amount);
            _orderRepository.Save(order);
            
            order.Status = OrderStatus.Confirmed;
            _orderRepository.Save(order);
            
            _notificationService.SendNotification(
                $"Your order for {productName} has been confirmed. Amount: ${amount}",
                customerEmail
            );
            
            _logger.Log($"Order {order.Id} created successfully for {customerName}");
        }
        catch (Exception ex)
        {
            _logger.LogError($"Failed to create order: {ex.Message}");
            throw;
        }
    }

    public void UpdateOrderStatus(int orderId, OrderStatus newStatus)
    {
        try
        {
            _logger.Log($"Updating order {orderId} status to {newStatus}");
            
            var order = _orderRepository.GetById(orderId);
            if (order == null)
            {
                _logger.LogWarning($"Order {orderId} not found");
                return;
            }
            
            order.Status = newStatus;
            _orderRepository.Save(order);
            
            if (newStatus == OrderStatus.Shipped)
            {
                _notificationService.SendNotification(
                    $"Your order for {order.ProductName} has been shipped!",
                    order.CustomerName
                );
            }
            
            _logger.Log($"Order {orderId} status updated to {newStatus}");
        }
        catch (Exception ex)
        {
            _logger.LogError($"Failed to update order status: {ex.Message}");
            throw;
        }
    }

    public void GetOrderDetails(int orderId)
    {
        var order = _orderRepository.GetById(orderId);
        if (order != null)
        {
            Console.WriteLine($"Order Details:");
            Console.WriteLine($"  ID: {order.Id}");
            Console.WriteLine($"  Customer: {order.CustomerName}");
            Console.WriteLine($"  Product: {order.ProductName}");
            Console.WriteLine($"  Amount: ${order.Amount}");
            Console.WriteLine($"  Status: {order.Status}");
            Console.WriteLine($"  Date: {order.OrderDate:yyyy-MM-dd HH:mm:ss}");
        }
        else
        {
            Console.WriteLine($"Order {orderId} not found");
        }
    }
}

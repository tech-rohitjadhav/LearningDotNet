namespace SolidPrinciplesConsoleApp.DependencyInversion;

/// <summary>
/// In-memory order repository implementation
/// Dependency Inversion Principle: Low-level module implementing abstraction
/// </summary>
public class InMemoryOrderRepository : IOrderRepository
{
    private readonly List<Order> _orders = new();
    private int _nextId = 1;

    public void Save(Order order)
    {
        if (order.Id == 0)
        {
            order.Id = _nextId++;
        }
        else
        {
            _orders.RemoveAll(o => o.Id == order.Id);
        }
        
        _orders.Add(order);
        Console.WriteLine($"Order {order.Id} saved to in-memory repository");
    }

    public Order? GetById(int id)
    {
        var order = _orders.FirstOrDefault(o => o.Id == id);
        if (order != null)
        {
            Console.WriteLine($"Retrieved order {id} from in-memory repository");
        }
        return order;
    }

    public List<Order> GetAll()
    {
        Console.WriteLine($"Retrieved {_orders.Count} orders from in-memory repository");
        return new List<Order>(_orders);
    }
}

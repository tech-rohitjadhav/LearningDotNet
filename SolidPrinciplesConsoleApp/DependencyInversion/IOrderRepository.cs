namespace SolidPrinciplesConsoleApp.DependencyInversion;

/// <summary>
/// Abstraction for order data operations
/// Dependency Inversion Principle: Repository abstraction
/// </summary>
public interface IOrderRepository
{
    void Save(Order order);
    Order? GetById(int id);
    List<Order> GetAll();
}

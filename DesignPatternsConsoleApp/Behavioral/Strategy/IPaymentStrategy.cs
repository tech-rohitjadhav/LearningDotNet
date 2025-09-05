namespace DesignPatternsConsoleApp.Behavioral.Strategy;

/// <summary>
/// Strategy interface
/// </summary>
public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
    string GetPaymentMethod();
}

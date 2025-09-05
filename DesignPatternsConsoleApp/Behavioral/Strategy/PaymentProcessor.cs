namespace DesignPatternsConsoleApp.Behavioral.Strategy;

/// <summary>
/// Context class that uses the strategy
/// </summary>
public class PaymentProcessor
{
    private IPaymentStrategy _paymentStrategy;

    public PaymentProcessor(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
        Console.WriteLine($"Payment method changed to: {paymentStrategy.GetPaymentMethod()}");
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Using {_paymentStrategy.GetPaymentMethod()} for payment...");
        _paymentStrategy.ProcessPayment(amount);
    }

    public string GetCurrentPaymentMethod()
    {
        return _paymentStrategy.GetPaymentMethod();
    }
}

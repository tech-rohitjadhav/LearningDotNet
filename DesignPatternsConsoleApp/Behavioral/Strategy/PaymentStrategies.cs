namespace DesignPatternsConsoleApp.Behavioral.Strategy;

/// <summary>
/// Concrete Strategy - Credit Card Payment
/// </summary>
public class CreditCardPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount:N2}");
        Console.WriteLine("Validating card details...");
        Console.WriteLine("Processing transaction...");
        Console.WriteLine("Payment successful!");
    }

    public string GetPaymentMethod()
    {
        return "Credit Card";
    }
}

/// <summary>
/// Concrete Strategy - PayPal Payment
/// </summary>
public class PayPalPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount:N2}");
        Console.WriteLine("Redirecting to PayPal...");
        Console.WriteLine("Authenticating user...");
        Console.WriteLine("Payment successful!");
    }

    public string GetPaymentMethod()
    {
        return "PayPal";
    }
}

/// <summary>
/// Concrete Strategy - Bank Transfer
/// </summary>
public class BankTransferPayment : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing bank transfer of ${amount:N2}");
        Console.WriteLine("Connecting to bank...");
        Console.WriteLine("Verifying account details...");
        Console.WriteLine("Transfer initiated!");
    }

    public string GetPaymentMethod()
    {
        return "Bank Transfer";
    }
}

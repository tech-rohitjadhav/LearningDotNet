namespace DesignPatternsConsoleApp.Behavioral.State;

/// <summary>
/// Context class
/// </summary>
public class VendingMachine
{
    private IVendingMachineState _currentState;
    private decimal _currentMoney;
    private readonly Dictionary<string, decimal> _products;

    public VendingMachine()
    {
        _currentState = new NoMoneyState(this);
        _currentMoney = 0;
        _products = new Dictionary<string, decimal>
        {
            { "Coke", 1.50m },
            { "Pepsi", 1.50m },
            { "Chips", 2.00m },
            { "Candy", 1.00m }
        };
    }

    public decimal CurrentMoney => _currentMoney;

    public void SetState(IVendingMachineState state)
    {
        _currentState = state;
    }

    public void AddMoney(decimal amount)
    {
        _currentMoney += amount;
    }

    public void DeductMoney(decimal amount)
    {
        _currentMoney -= amount;
    }

    public void ReturnAllMoney()
    {
        _currentMoney = 0;
    }

    public decimal GetProductPrice(string product)
    {
        return _products.TryGetValue(product, out var price) ? price : 0;
    }

    public void InsertMoney(decimal amount)
    {
        _currentState.InsertMoney(amount);
    }

    public void SelectProduct(string product)
    {
        _currentState.SelectProduct(product);
    }

    public void DispenseProduct()
    {
        _currentState.DispenseProduct();
    }

    public void ReturnMoney()
    {
        _currentState.ReturnMoney();
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Current money: ${_currentMoney}");
        Console.WriteLine($"Current state: {_currentState.GetType().Name}");
    }
}

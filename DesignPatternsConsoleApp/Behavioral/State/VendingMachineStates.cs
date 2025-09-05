namespace DesignPatternsConsoleApp.Behavioral.State;

/// <summary>
/// Concrete State - No Money
/// </summary>
public class NoMoneyState : IVendingMachineState
{
    private readonly VendingMachine _vendingMachine;

    public NoMoneyState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void InsertMoney(decimal amount)
    {
        _vendingMachine.AddMoney(amount);
        _vendingMachine.SetState(new HasMoneyState(_vendingMachine));
        Console.WriteLine($"Money inserted: ${amount}");
    }

    public void SelectProduct(string product)
    {
        Console.WriteLine("Please insert money first");
    }

    public void DispenseProduct()
    {
        Console.WriteLine("Please insert money first");
    }

    public void ReturnMoney()
    {
        Console.WriteLine("No money to return");
    }
}

/// <summary>
/// Concrete State - Has Money
/// </summary>
public class HasMoneyState : IVendingMachineState
{
    private readonly VendingMachine _vendingMachine;

    public HasMoneyState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void InsertMoney(decimal amount)
    {
        _vendingMachine.AddMoney(amount);
        Console.WriteLine($"Additional money inserted: ${amount}");
    }

    public void SelectProduct(string product)
    {
        var productPrice = _vendingMachine.GetProductPrice(product);
        if (productPrice > 0)
        {
            if (_vendingMachine.CurrentMoney >= productPrice)
            {
                _vendingMachine.SetState(new ProductSelectedState(_vendingMachine, product));
                Console.WriteLine($"Product selected: {product} (${productPrice})");
            }
            else
            {
                Console.WriteLine($"Insufficient money. Need ${productPrice}, have ${_vendingMachine.CurrentMoney}");
            }
        }
        else
        {
            Console.WriteLine($"Product '{product}' not available");
        }
    }

    public void DispenseProduct()
    {
        Console.WriteLine("Please select a product first");
    }

    public void ReturnMoney()
    {
        Console.WriteLine($"Returning ${_vendingMachine.CurrentMoney}");
        _vendingMachine.ReturnAllMoney();
        _vendingMachine.SetState(new NoMoneyState(_vendingMachine));
    }
}

/// <summary>
/// Concrete State - Product Selected
/// </summary>
public class ProductSelectedState : IVendingMachineState
{
    private readonly VendingMachine _vendingMachine;
    private readonly string _selectedProduct;

    public ProductSelectedState(VendingMachine vendingMachine, string selectedProduct)
    {
        _vendingMachine = vendingMachine;
        _selectedProduct = selectedProduct;
    }

    public void InsertMoney(decimal amount)
    {
        _vendingMachine.AddMoney(amount);
        Console.WriteLine($"Additional money inserted: ${amount}");
    }

    public void SelectProduct(string product)
    {
        Console.WriteLine($"Product already selected: {_selectedProduct}");
    }

    public void DispenseProduct()
    {
        var productPrice = _vendingMachine.GetProductPrice(_selectedProduct);
        _vendingMachine.DeductMoney(productPrice);
        Console.WriteLine($"Dispensing {_selectedProduct}");
        
        var change = _vendingMachine.CurrentMoney;
        if (change > 0)
        {
            Console.WriteLine($"Returning change: ${change}");
            _vendingMachine.ReturnAllMoney();
        }
        
        _vendingMachine.SetState(new NoMoneyState(_vendingMachine));
    }

    public void ReturnMoney()
    {
        Console.WriteLine($"Returning ${_vendingMachine.CurrentMoney}");
        _vendingMachine.ReturnAllMoney();
        _vendingMachine.SetState(new NoMoneyState(_vendingMachine));
    }
}

namespace DesignPatternsConsoleApp.Structural.Decorator;

/// <summary>
/// Base decorator class
/// </summary>
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return _coffee.GetCost();
    }
}

/// <summary>
/// Concrete decorator - Milk
/// </summary>
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Milk";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 0.50;
    }
}

/// <summary>
/// Concrete decorator - Sugar
/// </summary>
public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Sugar";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 0.25;
    }
}

/// <summary>
/// Concrete decorator - Whipped Cream
/// </summary>
public class WhippedCreamDecorator : CoffeeDecorator
{
    public WhippedCreamDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Whipped Cream";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 0.75;
    }
}

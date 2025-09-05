namespace DesignPatternsConsoleApp.Behavioral.Visitor;

/// <summary>
/// Concrete Visitor - Tax Calculator
/// </summary>
public class TaxCalculator : IVisitor
{
    private decimal _totalTax = 0;

    public void Visit(Book book)
    {
        var tax = book.Price * 0.05m; // 5% tax on books
        _totalTax += tax;
        Console.WriteLine($"Tax on '{book.Name}' by {book.Author}: ${tax:F2}");
    }

    public void Visit(Electronics electronics)
    {
        var tax = electronics.Price * 0.15m; // 15% tax on electronics
        _totalTax += tax;
        Console.WriteLine($"Tax on '{electronics.Name}' ({electronics.Brand}): ${tax:F2}");
    }

    public void Visit(Clothing clothing)
    {
        var tax = clothing.Price * 0.10m; // 10% tax on clothing
        _totalTax += tax;
        Console.WriteLine($"Tax on '{clothing.Name}' (Size {clothing.Size}): ${tax:F2}");
    }

    public decimal GetTotalTax()
    {
        return _totalTax;
    }

    public void Reset()
    {
        _totalTax = 0;
    }
}

/// <summary>
/// Concrete Visitor - Discount Calculator
/// </summary>
public class DiscountCalculator : IVisitor
{
    private decimal _totalDiscount = 0;

    public void Visit(Book book)
    {
        var discount = book.Price * 0.10m; // 10% discount on books
        _totalDiscount += discount;
        Console.WriteLine($"Discount on '{book.Name}': ${discount:F2}");
    }

    public void Visit(Electronics electronics)
    {
        var discount = electronics.Price * 0.05m; // 5% discount on electronics
        _totalDiscount += discount;
        Console.WriteLine($"Discount on '{electronics.Name}': ${discount:F2}");
    }

    public void Visit(Clothing clothing)
    {
        var discount = clothing.Price * 0.15m; // 15% discount on clothing
        _totalDiscount += discount;
        Console.WriteLine($"Discount on '{clothing.Name}': ${discount:F2}");
    }

    public decimal GetTotalDiscount()
    {
        return _totalDiscount;
    }

    public void Reset()
    {
        _totalDiscount = 0;
    }
}

namespace DesignPatternsConsoleApp.Behavioral.Visitor;

/// <summary>
/// Concrete Element - Book
/// </summary>
public class Book : IProduct
{
    public string Name { get; }
    public decimal Price { get; }
    public string Author { get; }

    public Book(string name, decimal price, string author)
    {
        Name = name;
        Price = price;
        Author = author;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

/// <summary>
/// Concrete Element - Electronics
/// </summary>
public class Electronics : IProduct
{
    public string Name { get; }
    public decimal Price { get; }
    public string Brand { get; }

    public Electronics(string name, decimal price, string brand)
    {
        Name = name;
        Price = price;
        Brand = brand;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

/// <summary>
/// Concrete Element - Clothing
/// </summary>
public class Clothing : IProduct
{
    public string Name { get; }
    public decimal Price { get; }
    public string Size { get; }

    public Clothing(string name, decimal price, string size)
    {
        Name = name;
        Price = price;
        Size = size;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

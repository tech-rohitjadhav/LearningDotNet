namespace DesignPatternsConsoleApp.Behavioral.ChainOfResponsibility;

/// <summary>
/// Request class
/// </summary>
public class Request
{
    public string Type { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;

    public Request(string type, decimal amount, string description)
    {
        Type = type;
        Amount = amount;
        Description = description;
    }
}

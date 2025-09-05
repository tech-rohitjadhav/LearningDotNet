namespace DesignPatternsConsoleApp.Behavioral.State;

/// <summary>
/// State interface
/// </summary>
public interface IVendingMachineState
{
    void InsertMoney(decimal amount);
    void SelectProduct(string product);
    void DispenseProduct();
    void ReturnMoney();
}

using WarehouseManagementSystem.Domain;

namespace WarehouseManagementSystem.Business
{
  public class OrderProcessor
  {

    public delegate void OrderInitialized();
    public OrderInitialized OnOrderInitialized { get; set; }
    public delegate void ProcessCompleted();

    private void Initialize(Order order)
    {
      ArgumentNullException.ThrowIfNull(order);
      OnOrderInitialized?.Invoke();
    }

    public void Process(Order order,ProcessCompleted onProcessCompleted=default)
    {
      // Run some code..

      Initialize(order);
      Console.WriteLine("XXXXXXX");

      // How do I produce a shipping label?
      onProcessCompleted?.Invoke();
    }
  }
}
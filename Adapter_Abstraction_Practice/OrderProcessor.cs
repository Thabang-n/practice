public class OrderProcessor : Adaptor
{
  public override void ExecuteCode()
  {
    Console.WriteLine("Placing order...");
    bool isStockAvail = false;
    if (!isStockAvail)
    {
      throw new InvalidOperationException("Location not specified");
    }
    Console.WriteLine("Order placed...");
  }
}
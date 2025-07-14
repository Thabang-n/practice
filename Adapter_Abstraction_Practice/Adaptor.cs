public abstract class Adaptor
{
  public abstract void ExecuteCode();

  private void StartTransaction() { Console.WriteLine("Transaction Started"); }
  private void CommitTransaction() { Console.WriteLine("Transaction Committed"); }
  private void RollBackTransaction() { Console.WriteLine("Transaction RollBack"); }

  public void PerformActivity()
  {
    try
    {
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("*****************************");
      StartTransaction();
      ExecuteCode();
      CommitTransaction();
      Console.WriteLine("");
      Console.WriteLine("");

    }
    catch (Exception ex) { Console.WriteLine(ex.Message); RollBackTransaction(); }


  }
}
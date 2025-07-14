
Console.WriteLine("Welcome Place your first order");

void ShowOutput(Adaptor adaptor)
{
  adaptor.PerformActivity();
}

ShowOutput(new OrderProcessor());



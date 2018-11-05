using System;

namespace DesignPatterns.Pattern.ProxyPattern.Virtual {
  public class ExampleExpensiveObject : IExampleExpensiveObject {
    public ExampleExpensiveObject(string seed) {
      Console.WriteLine("[RealSubject] Construction");
      System.Threading.Thread.Sleep(2000);
      Text = $"Expensive construction created text with seed: {seed}";
    }

    public string Text { get; }
  }
}

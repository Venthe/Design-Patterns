using System;

namespace DesignPatterns.ProxyPattern.Virtual {
  public class ExampleExpensiveObject : IExampleExpensiveObject {
    public string Text { get; }

    public ExampleExpensiveObject(string seed) {
      Console.Out.WriteLine("[RealSubject] Construction");
      System.Threading.Thread.Sleep(2000);
      Text = $"Expensive construction created text with seed: {seed}";
    }
  }
}

using System;

namespace DesignPatterns.SingletonPattern {
  public class SingletonPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var singleton1 = new Singleton();
      var singleton2 = new Singleton();

      Console.Out.WriteLine($"This should be true: {singleton1.GetInstance().Equals(singleton2.GetInstance())}");
    }
  }
}

using System;

namespace DesignPatterns.SoftwareDesignPattern.Creational.Singleton {
  public class SingletonPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var singleton1 = new SampleSingleton();
      var singleton2 = new SampleSingleton();

      Console.WriteLine($"This should be true: {singleton1.GetInstance().Equals(singleton2.GetInstance())}");
    }
  }
}

using System;

namespace DesignPatterns.SoftwareDesignPattern.Creational.Singleton {
  public class SingletonPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var singleton1 = SampleSingleton.GetInstance();
      var singleton2 = SampleSingleton.GetInstance();

      Console.WriteLine($"This should be true: {singleton1.GetInstance().Equals(singleton2.GetInstance())}");
    }
  }
}

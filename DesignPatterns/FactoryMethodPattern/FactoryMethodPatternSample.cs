using System;
using DesignPatterns.FactoryMethodPattern.Factory;

namespace DesignPatterns.FactoryMethodPattern {
  public class FactoryMethodPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var objectCreatedByFactoryMethod = new Creator1().FactoryMethod();
      var otherMethodResult = new Creator1().OtherStuff();

      Console.Out.WriteLine($"FactoryMethod owner can have other methods: {otherMethodResult}");
    }
  }
}

using System;
using DesignPatterns.Pattern.FactoryMethodPattern.Factory;

namespace DesignPatterns.Pattern.FactoryMethodPattern {
  public class FactoryMethodPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var objectCreatedByFactoryMethod = Creator1.FactoryMethod();
      var otherMethodResult = new Creator1().OtherStuff();

      Console.Out.WriteLine($"FactoryMethod owner can have other methods: {otherMethodResult}");
    }
  }
}

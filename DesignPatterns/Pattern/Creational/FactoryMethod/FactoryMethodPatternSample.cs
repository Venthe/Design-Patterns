using System;
using DesignPatterns.Pattern.Creational.FactoryMethod.Factory;

namespace DesignPatterns.Pattern.Creational.FactoryMethod {
  public class FactoryMethodPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var objectCreatedByFactoryMethod = Creator1.FactoryMethod();
      var otherMethodResult = new Creator1().OtherStuff();

      Console.WriteLine($"FactoryMethod owner can have other methods: {otherMethodResult}");
    }
  }
}

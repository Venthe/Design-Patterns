using System;

namespace DesignPatterns.FactoryMethodPattern.Factory {
  // Should be only used as concrete factory method
  public class Creator1 {
    public static IProduct FactoryMethod() {
      Console.Out.WriteLine($"Factory method called, will create {nameof(Product)} with {nameof(IProduct)} type");
      return new Product();
    }

    public string OtherStuff() => "Some action";
  }
}

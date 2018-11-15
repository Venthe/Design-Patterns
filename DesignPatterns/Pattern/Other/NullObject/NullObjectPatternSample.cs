using System;

namespace DesignPatterns.Pattern.Other.NullObject {
  public class NullObjectPatternSample : IDesignPatternSample {
    public void ShowSample() {
      IAnimal animal = new Cat();
      Console.WriteLine("Cat: " + animal.Speak());
      animal = new Dog();
      Console.WriteLine("Dog: " + animal.Speak());
      animal = new NullObjectAnimal();
      Console.WriteLine("Null Animal: " + animal.Speak());
    }
  }
}

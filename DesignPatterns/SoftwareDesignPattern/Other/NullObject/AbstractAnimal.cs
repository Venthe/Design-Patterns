using System;

namespace DesignPatterns.SoftwareDesignPattern.Other.NullObject {
  public class AbstractAnimal : IAnimal {
    public static IAnimal NullAnimal { get; } = new NullAnimal();

    public virtual string Speak() => throw new NotImplementedException();
  }
}

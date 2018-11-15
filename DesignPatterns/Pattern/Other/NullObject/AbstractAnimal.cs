using System;

namespace DesignPatterns.Pattern.Other.NullObject {
  public class AbstractAnimal : IAnimal {
    public static IAnimal NullAnimal { get; } = new NullAnimal();

    public virtual string Speak() => throw new NotImplementedException();
  }
}

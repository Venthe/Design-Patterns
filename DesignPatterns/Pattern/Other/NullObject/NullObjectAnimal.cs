namespace DesignPatterns.Pattern.Other.NullObject {
  public class NullObjectAnimal : IAnimal {
    public string Speak() => default(string);
  }
}

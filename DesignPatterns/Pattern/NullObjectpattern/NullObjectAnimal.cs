namespace DesignPatterns.Pattern.NullObjectpattern {
  public class NullObjectAnimal : IAnimal {
    public string Speak() => default(string);
  }
}

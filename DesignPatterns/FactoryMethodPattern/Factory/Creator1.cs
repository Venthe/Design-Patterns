namespace DesignPatterns.FactoryMethodPattern.Factory {
  // Should be only used as concrete factory method
  public class Creator1 {
    public IProduct FactoryMethod() => new Product();
    public string OtherStuff() => "Some action";
  }
}

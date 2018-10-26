namespace DesignPatterns.DecoratorPattern {
  abstract public class AbstractBeverage {
    public abstract int GetPrice();
    public override string ToString() => GetPrice().ToString();
  }
}

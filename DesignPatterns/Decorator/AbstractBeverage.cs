namespace DesignPatterns.Decorator {
  abstract public class AbstractBeverage {
    public abstract int GetPrice();
    public override string ToString() => this.GetPrice().ToString();
  }
}

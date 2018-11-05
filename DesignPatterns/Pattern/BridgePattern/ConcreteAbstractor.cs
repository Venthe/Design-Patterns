namespace DesignPatterns.Pattern.BridgePattern {
  public class ConcreteAbstractor : Abstractor {
    public ConcreteAbstractor()
      : base(new ConcreteImplementor()) {
    }

    public new string DoThings() => $"Concrete {base.DoThings()}";
  }
}

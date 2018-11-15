namespace DesignPatterns.Pattern.Structural.Bridge {
  public class ConcreteAbstractor : Abstractor {
    public ConcreteAbstractor()
      : base(new ConcreteImplementor()) {
    }

    public new string DoThings() => $"Concrete {base.DoThings()}";
  }
}

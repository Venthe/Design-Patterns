namespace DesignPatterns.Pattern.Structural.Bridge {
  public abstract class Abstractor {
    private readonly IImplementor implementor;

    protected Abstractor(IImplementor implementor) {
      this.implementor = implementor;
    }

    public string DoThings() => $"Abstractor {implementor.DoStuff()}";
  }
}

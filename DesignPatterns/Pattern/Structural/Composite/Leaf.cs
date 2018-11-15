namespace DesignPatterns.Pattern.Structural.Composite {
  public class Leaf : IComposite {
    public Leaf(string name) {
      Name = name;
    }

    public string Name { get; }
  }
}

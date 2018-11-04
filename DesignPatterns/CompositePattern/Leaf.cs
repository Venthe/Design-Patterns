namespace DesignPatterns.CompositePattern {
  public class Leaf : IComposite {
    public Leaf(string name) {
      Name = name;
    }

    public string Name { get; }
  }
}

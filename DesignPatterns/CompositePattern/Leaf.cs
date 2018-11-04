namespace DesignPatterns.CompositePattern {
  public class Leaf : IComposite {
    public string Name { get; }
    public Leaf(string name) => Name = name;
  }
}

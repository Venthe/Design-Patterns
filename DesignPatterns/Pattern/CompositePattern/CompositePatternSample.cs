using System;

namespace DesignPatterns.Pattern.CompositePattern {
  // Compose objects into tree structures to represent whole-part hierarchies.
  // Composite lets clients treat individual objects and compositions of objects uniformly.
  public class CompositePatternSample : IDesignPatternSample {
    public void ShowSample() {
      var container1 = GetContainer1();

      var leaf1 = new Leaf("Leaf 1");
      var root = ComposeRoot(container1, leaf1);

      Console.Out.WriteLine("Leaf1: " + leaf1.Name);
      Console.Out.WriteLine("root: " + root.Name);
      Console.Out.WriteLine("container 1: " + container1.Name);
    }

    private static CompositeContainer GetContainer1() {
      var leaf3 = new Leaf("Leaf 3");
      var container1 = new CompositeContainer();
      container1.Children.Add(leaf3);
      return container1;
    }

    private static CompositeContainer ComposeRoot(CompositeContainer container1, Leaf leaf1) {
      var container2 = GetContainer2(container1);

      var root = new CompositeContainer();
      root.Children.Add(leaf1);
      root.Children.Add(container2);
      return root;
    }

    private static CompositeContainer GetContainer2(CompositeContainer container1) {
      var leaf2 = new Leaf("Leaf 2");
      var container2 = new CompositeContainer();
      container2.Children.Add(leaf2);
      container2.Children.Add(container1);
      return container2;
    }
  }
}

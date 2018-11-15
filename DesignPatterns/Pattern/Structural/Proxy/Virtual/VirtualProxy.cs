using System;

namespace DesignPatterns.Pattern.Structural.Proxy.Virtual {
  // Controls access to resource that is expensive to create, i.e. caching
  public class VirtualProxy : IExampleExpensiveObject {
    private readonly string seed;

    private ExampleExpensiveObject expensiveObject;

    public VirtualProxy(string seed) {
      Console.WriteLine("[Proxy] Constructor");
      this.seed = seed;
    }

    public string Text {
      get {
        TryInstantiateExpensiveObject();

        return expensiveObject.Text;
      }
    }

    private void TryInstantiateExpensiveObject() {
      if (expensiveObject == null) {
        Console.WriteLine("[Proxy] Deferred instantiation");
        expensiveObject = new ExampleExpensiveObject(seed);
      }
    }
  }
}

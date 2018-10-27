using System;

namespace DesignPatterns.ProxyPattern.Virtual {
  // Controls access to resource that is expensive to create, i.e. caching
  public class VirtualProxy : IExampleExpensiveObject {
    private ExampleExpensiveObject expensiveObject;

    private readonly string seed;

    public string Text {
      get {
        TryInstantiateExpensiveObject();

        return expensiveObject.Text;
      }
    }

    private void TryInstantiateExpensiveObject() {
      if (expensiveObject == null) {
        Console.Out.WriteLine("[Proxy] Deferred instantiation");
        expensiveObject = new ExampleExpensiveObject(seed);
      }
    }

    public VirtualProxy(string seed) {
      Console.Out.WriteLine("[Proxy] Constructor");
      this.seed = seed;
    }
  }
}

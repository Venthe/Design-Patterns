using System;

namespace DesignPatterns.BridgePattern {
  public class BridgePatternSample : IDesignPatternSample {
    public void ShowSample() {
      var bridgeExample = new ConcreteAbstractor();

      Console.Out.WriteLine(bridgeExample.DoThings());
    }
  }
}

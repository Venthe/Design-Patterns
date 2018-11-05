using System;

namespace DesignPatterns.Pattern.BridgePattern {
  public class BridgePatternSample : IDesignPatternSample {
    public void ShowSample() {
      var bridgeExample = new ConcreteAbstractor();

      Console.WriteLine(bridgeExample.DoThings());
    }
  }
}

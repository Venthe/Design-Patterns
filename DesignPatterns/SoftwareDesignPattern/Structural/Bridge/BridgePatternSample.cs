using System;

namespace DesignPatterns.SoftwareDesignPattern.Structural.Bridge {
  public class BridgePatternSample : IDesignPatternSample {
    public void ShowSample() {
      var bridgeExample = new ConcreteAbstractor();

      Console.WriteLine(bridgeExample.DoThings());
    }
  }
}

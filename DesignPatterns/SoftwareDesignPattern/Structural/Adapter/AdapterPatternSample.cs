using DesignPatterns.SoftwareDesignPattern.Structural.Adapter.Target;

namespace DesignPatterns.SoftwareDesignPattern.Structural.Adapter {
  public class AdapterPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var adapter = new TargetAdapter(new NonAdaptedTarget());
      adapter.MyNameForOriginalPublish();
    }
  }
}

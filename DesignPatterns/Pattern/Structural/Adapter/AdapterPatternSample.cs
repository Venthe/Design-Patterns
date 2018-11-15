using DesignPatterns.Pattern.Structural.Adapter.Target;

namespace DesignPatterns.Pattern.Structural.Adapter {
  public class AdapterPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var adapter = new TargetAdapter(new NonAdaptedTarget());
      adapter.MyNameForOriginalPublish();
    }
  }
}

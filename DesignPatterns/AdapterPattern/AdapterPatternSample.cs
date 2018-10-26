using DesignPatterns.AdapterPattern.Target;

namespace DesignPatterns.AdapterPattern {
  public class AdapterPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var adapter = new TargetAdapter(new NonAdaptedTarget());
      adapter.MyNameForOriginalPublish();
    }
  }
}

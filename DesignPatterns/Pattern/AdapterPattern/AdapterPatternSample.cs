using DesignPatterns.Pattern.AdapterPattern.Target;

namespace DesignPatterns.Pattern.AdapterPattern {
  public class AdapterPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var adapter = new TargetAdapter(new NonAdaptedTarget());
      adapter.MyNameForOriginalPublish();
    }
  }
}

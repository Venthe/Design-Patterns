using DesignPatterns.AdapterPattern.Target;

namespace DesignPatterns.AdapterPattern {
  public class TargetAdapter : ITargetAdapter {
    private readonly ITarget target;

    public TargetAdapter(ITarget target) {
      this.target = target;
    }

    public void MyNameForOriginalPublish() => target.Publish();
  }
}

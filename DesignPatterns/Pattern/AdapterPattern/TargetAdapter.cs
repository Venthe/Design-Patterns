using DesignPatterns.Pattern.AdapterPattern.Target;

namespace DesignPatterns.Pattern.AdapterPattern {
  public class TargetAdapter : ITargetAdapter {
    private readonly ITarget target;

    public TargetAdapter(ITarget target) {
      this.target = target;
    }

    public void MyNameForOriginalPublish() => target.Publish();
  }
}

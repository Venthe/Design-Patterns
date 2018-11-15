using DesignPatterns.SoftwareDesignPattern.Structural.Adapter.Target;

namespace DesignPatterns.SoftwareDesignPattern.Structural.Adapter {
  public class TargetAdapter : ITargetAdapter {
    private readonly ITarget target;

    public TargetAdapter(ITarget target) {
      this.target = target;
    }

    public void MyNameForOriginalPublish() => target.Publish();
  }
}

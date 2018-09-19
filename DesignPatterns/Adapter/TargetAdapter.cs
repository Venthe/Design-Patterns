using DesignPatterns.Adapter.Target;

namespace DesignPatterns.Adapter {
  class TargetAdapter : ITargetAdapter {
    private readonly ITarget target;

    public TargetAdapter(ITarget target) {
      this.target = target;
    }

    public void Publish2() => this.target.Publish();
  }
}

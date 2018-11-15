namespace DesignPatterns.SoftwareDesignPattern.Behavioral.State {
  public class ClosedState : ITurnstileState {
    public ITurnstileState Alarm() => new ClosedState();

    public ITurnstileState Enter() => this;

    public ITurnstileState Pay() => new ProcessingPaymentState();

    public ITurnstileState PayFailed() => this;

    public ITurnstileState PayOk() => this;

    public string GetCurrentState() => "Closed";
  }
}

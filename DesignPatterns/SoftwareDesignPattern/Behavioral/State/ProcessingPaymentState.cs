namespace DesignPatterns.SoftwareDesignPattern.Behavioral.State {
  public class ProcessingPaymentState : ITurnstileState {
    public ITurnstileState Alarm() => new ClosedState();

    public ITurnstileState Enter() => this;

    public ITurnstileState Pay() => this;

    public ITurnstileState PayFailed() => new ClosedState();

    public ITurnstileState PayOk() => new OpenState();

    public string GetCurrentState() => "Processing payment...";
  }
}

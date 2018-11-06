namespace DesignPatterns.Pattern.StatePattern {
  public interface ITurnstileState {
    ITurnstileState Enter();

    ITurnstileState PayOk();

    ITurnstileState PayFailed();

    ITurnstileState Pay();

    ITurnstileState Alarm();

    string GetCurrentState();
  }
}

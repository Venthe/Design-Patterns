namespace DesignPatterns.Pattern.StatePattern {
  public class TurnstileContextDecorator : ITurnstileState {
    private ITurnstileState state;

    public TurnstileContextDecorator(ITurnstileState initialState) {
      this.state = initialState;
    }

    public ITurnstileState Alarm() => state = state.Alarm();

    public ITurnstileState Enter() => state = state.Enter();

    public string GetCurrentState() => state.GetCurrentState();

    public ITurnstileState Pay() => state = state.Pay();

    public ITurnstileState PayFailed() => state = state.PayFailed();

    public ITurnstileState PayOk() => state = state.PayOk();
  }
}

using System;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.State {
  // Allows an object to alter it's behaviour when it's internal state changes.
  // Object will appear to change it's class
  public class StatePatternSample : IDesignPatternSample {
    public void ShowSample() {
      ITurnstileState state = new TurnstileContextDecorator(new ClosedState());
      Console.WriteLine(state.GetCurrentState());
      state.Enter();
      Console.WriteLine(state.GetCurrentState());
      state.PayOk();
      Console.WriteLine(state.GetCurrentState());
      state.Pay();
      Console.WriteLine(state.GetCurrentState());
      state.PayFailed();
      Console.WriteLine(state.GetCurrentState());
    }
  }
}

using System;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Observer.WithSubscriber {
  // TODO: Make it type safe?
  public static class SampleTransformations {
    public static dynamic ToUpper(dynamic value) => value.ToString().ToUpper();

    public static Func<dynamic, dynamic> Log() => VoidFunctionToNull(Console.WriteLine);

    public static Func<dynamic, dynamic> Map(Func<dynamic, dynamic> transformation) => value => transformation?.Invoke(value);

    public static Func<dynamic, dynamic> Tap(Action<dynamic> sideEffect) => Tap(VoidFunctionToNull(sideEffect));

    public static Func<dynamic, dynamic> Tap(Func<dynamic, dynamic> sideEffect) => value => sideEffect?.Invoke(value);

    private static Func<dynamic, dynamic> VoidFunctionToNull(Action<dynamic> sideEffect) => value => {
      sideEffect?.Invoke(value);
      return null;
    };
  }
}

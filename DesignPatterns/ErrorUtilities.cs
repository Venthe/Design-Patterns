using System;

namespace DesignPatterns {
  public sealed class ErrorUtilities : Attribute {
    public static void LogException(Action action) {
      try {
        action?.Invoke();
      }
      catch (Exception exception) {
        LogExceptionAsConsole(exception);
      }
    }

    public static T LogException<T>(Func<T> function) {
      if (function == null) {
        return default(T);
      }

      try {
        return function.Invoke();
      }
      catch (Exception exception) {
        LogExceptionAsConsole(exception);
      }

      return default(T);
    }

    private static void LogExceptionAsConsole(Exception exception) => Console.Out.WriteLine(exception);
  }
}

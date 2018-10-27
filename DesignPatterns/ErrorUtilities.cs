using System;

namespace DesignPatterns {
  // TODO: Convert to attribute
  public static class ErrorUtilities {
    public static void LogException(Action action) {
      try {
        action.Invoke();
      }
      catch (Exception exception) {
        LogExceptionAsConsole(exception);
      }
    }

    public static T LogException<T>(Func<T> func) {
      try {
        return func.Invoke();
      }
      catch (Exception exception) {
        LogExceptionAsConsole(exception);
      }

      return default(T);
    }

    private static void LogExceptionAsConsole(Exception e) => Console.Out.WriteLine($"{e.GetType().Name}: {e.Message}");
  }
}

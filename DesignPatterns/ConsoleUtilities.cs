using System;

namespace DesignPatterns {
  public class ConsoleUtilities {
    private readonly int maxLineLength;
    private readonly char paddingCharacter;

    public ConsoleUtilities(int maxLineLength = 78, char paddingCharacter = '-') {
      this.maxLineLength = maxLineLength;
      this.paddingCharacter = paddingCharacter;
    }

    public void InvokeInConsoleBlock(Action callback) {
      Console.WriteLine(callback.Method.ToString().PadRight(maxLineLength, paddingCharacter));
      callback.Invoke();
      Console.WriteLine(string.Empty.PadRight(maxLineLength, paddingCharacter));
      Console.WriteLine();
    }

    public void PauseApp() {
      Console.Out.WriteLine("Pause...");
      Console.ReadKey();
    }
  }
}

using System;

namespace DesignPatterns {
  public class ConsoleUtilities {
    private readonly int maxLineLength;
    private readonly char paddingCharacter;

    public ConsoleUtilities(int maxLineLength = 78, char paddingCharacter = '-') {
      this.maxLineLength = maxLineLength;
      this.paddingCharacter = paddingCharacter;
    }

    public void InvokeInConsoleBlock(IDesignPatternSample sample) {
      Console.WriteLine(sample.GetType().Name.PadRight(maxLineLength, paddingCharacter));
      sample.ShowSample();
      Console.WriteLine(string.Empty.PadRight(maxLineLength, paddingCharacter));
      Console.WriteLine();
    }

    public void PauseApp() {
      Console.Out.WriteLine("Pause...");
      Console.ReadKey();
    }
  }
}

using System;
using DesignPatterns.SoftwareDesignPattern;

namespace DesignPatterns.Utilities {
  public class ConsoleUtilities {
    private readonly int maxLineLength;
    private readonly char paddingCharacter;

    public ConsoleUtilities(int maxLineLength = 78, char paddingCharacter = '-') {
      this.maxLineLength = maxLineLength;
      this.paddingCharacter = paddingCharacter;
    }

    public static void PauseApp(string text = "Pause...") {
      Console.WriteLine(text);
      Console.ReadKey();
    }

    public void DisplayInBlock(IDesignPatternSample sample) {
      Console.WriteLine(PadCenter(sample.GetType().Name));
      sample.ShowSample();
      Console.WriteLine(new string(paddingCharacter, maxLineLength));
      Console.WriteLine();
    }

    private string PadCenter(string text) {
      var lengthOfText = text.Length;
      if (lengthOfText >= maxLineLength) {
        return text;
      }

      var textPaddedLeft = string.Concat(LefthandsidePadding(lengthOfText), text);

      return textPaddedLeft.PadRight(maxLineLength, paddingCharacter);
    }

    private string LefthandsidePadding(int lengthOfText) {
      var lowerBoundFillSize = HalfOfPaddingRequiredToCenterText(lengthOfText);

      return new string(paddingCharacter, lowerBoundFillSize);
    }

    private int HalfOfPaddingRequiredToCenterText(int lengthOfText) => (int)Math.Floor((maxLineLength - lengthOfText) / 2d);
  }
}

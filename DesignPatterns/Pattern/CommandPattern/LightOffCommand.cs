using System;

namespace DesignPatterns.Pattern.CommandPattern {
  public class LightOffCommand : ICommand {
    private static int counter = 0;

    public void Do() => Console.Out.WriteLine($"LightsOffCommand: Do | {++counter}");

    public void Undo() => Console.Out.WriteLine($"LightsOffCommand: Undo | {--counter}");
  }
}

using System;

namespace DesignPatterns.Pattern.Behavioral.Command {
  public class LightOffCommand : ICommand {
    private static int counter = 0;

    public void Do() => Console.WriteLine($"LightsOffCommand: Do | {++counter}");

    public void Undo() => Console.WriteLine($"LightsOffCommand: Undo | {--counter}");
  }
}

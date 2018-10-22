using System;

namespace DesignPatterns.Command {
  class LightOffCommand : ICommand {
    private static int counter = 0;

    public void Do() => Console.Out.WriteLine($"LightsOffCommand: Do | {++counter}");
    public void Undo() => Console.Out.WriteLine($"LightsOffCommand: Undo | {--counter}");
  }
}

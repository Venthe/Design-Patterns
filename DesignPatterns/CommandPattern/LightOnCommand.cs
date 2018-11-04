using System;

namespace DesignPatterns.CommandPattern {
  public class LightOnCommand : ICommand {
    public void Do() => Console.Out.WriteLine("LightOnCommand: Do");

    public void Undo() => Console.Out.WriteLine("LightOnCommand: Undo");
  }
}

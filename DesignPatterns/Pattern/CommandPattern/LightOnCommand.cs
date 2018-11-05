using System;

namespace DesignPatterns.Pattern.CommandPattern {
  public class LightOnCommand : ICommand {
    public void Do() => Console.WriteLine("LightOnCommand: Do");

    public void Undo() => Console.WriteLine("LightOnCommand: Undo");
  }
}

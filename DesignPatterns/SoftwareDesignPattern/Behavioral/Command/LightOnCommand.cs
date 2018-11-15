using System;

namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Command {
  public class LightOnCommand : ICommand {
    public void Do() => Console.WriteLine("LightOnCommand: Do");

    public void Undo() => Console.WriteLine("LightOnCommand: Undo");
  }
}

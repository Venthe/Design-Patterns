using System.Collections.Generic;

namespace DesignPatterns.CommandPattern {
  public class BatchInvoker {
    public ICollection<ICommand> Commands { get; } = new List<ICommand>();

    public void DoAll() {
      foreach (var command in Commands) {
        command.Do();
      }
    }

    public void UndoAll() {
      foreach (var command in Commands) {
        command.Undo();
      }
    }
  }
}

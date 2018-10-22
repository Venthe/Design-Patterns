using System.Collections.Generic;

namespace DesignPatterns.Command {
  class Invoker {
    public ICollection<ICommand> commands = new List<ICommand>();

    public void DoAll() {
      foreach (var command in commands) {
        command.Do();
      }
    }

    public void UndoAll() {
      foreach (var command in commands) {
        command.Undo();
      }
    }
  }
}

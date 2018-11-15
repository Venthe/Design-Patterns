namespace DesignPatterns.SoftwareDesignPattern.Behavioral.Command {
  public class CommandPatternSample : IDesignPatternSample {
    public void ShowSample() {
      var batchInvoker = new BatchInvoker();
      batchInvoker.Commands.Add(new LightOffCommand());
      batchInvoker.Commands.Add(new LightOffCommand());
      batchInvoker.Commands.Add(new LightOffCommand());
      batchInvoker.Commands.Add(new LightOnCommand());

      batchInvoker.DoAll();
      batchInvoker.UndoAll();

      var remote = new Remote {
        RemoteKey1 = new LightOffCommand(),
        RemoteKey2 = new LightOnCommand()
      };

      remote.RemoteKey1.Do();
      remote.RemoteKey2.Undo();
    }
  }
}

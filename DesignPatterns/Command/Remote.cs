using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command {
  class Remote {
    public ICommand RemoteKey1 { set; get; }
    public ICommand RemoteKey2 { set; get; }
  }
}

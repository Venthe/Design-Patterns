using System.Threading.Tasks;

namespace DesignPatterns.SoftwareDesignPattern.Structural.Proxy.Remote {
  // This class does NOT exist - it's for example a result of a REST call
  public class RemoteResourceAccessor : IRemoteResourceAccessor {
    public string GetData() => "Sample async data";

    public async Task<string> RemoteRESTApiEndpointAsync() {
      await Task.Delay(500).ConfigureAwait(false);
      return GetData();
    }
  }
}

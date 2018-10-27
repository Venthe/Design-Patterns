using System.Threading.Tasks;

namespace DesignPatterns.ProxyPattern.Remote {
  // This class does NOT exist - it's for example a result of a REST call
  public class RemoteResourceAccessor : IRemoteResourceAccessor {
    public string GetData() => "Sample async data";

    public async Task<string> RemoteRESTApiEndpoint() {
      await Task.Delay(2000).ConfigureAwait(false);
      return GetData();
    }
  }
}

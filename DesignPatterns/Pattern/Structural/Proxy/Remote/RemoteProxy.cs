namespace DesignPatterns.Pattern.Structural.Proxy.Remote {
  // Access resource that is remote, proxy is used to encapsulate logic that is required to access such data
  // I.e. HTTP calls, sockets and so on. As one example, one can return a promise.
  public class RemoteProxy : IRemoteResourceAccessor {
    private readonly RemoteResourceAccessor remoteResource = new RemoteResourceAccessor();

    // HTTP Code
    public string GetData() => remoteResource.RemoteRESTApiEndpointAsync().Result;
  }
}

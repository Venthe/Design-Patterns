using System.Security.Authentication;

namespace DesignPatterns.Pattern.ProxyPattern.Protection {
  // Restricts access to underlying resource
  public class ProtectionProxy : ISensitiveClass {
    private readonly ISensitiveClass sensitiveClass;

    public ProtectionProxy(bool hasPermission) {
      HasPermission = hasPermission;
      sensitiveClass = new SensitiveClass();
    }

    public bool HasPermission { get; }

    /// <exception cref="AuthenticationException ">User has no permission to call this method</exception>
    public string SensitiveMethod() {
      if (!HasPermission) {
        throw new AuthenticationException();
      }

      return sensitiveClass.SensitiveMethod();
    }
  }
}

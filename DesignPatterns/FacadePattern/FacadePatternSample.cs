namespace DesignPatterns.FacadePattern {
  public class FacadePatternSample : IDesignPatternSample {
    public void ShowSample() {
      var facade = new Facade();
      facade.UseMethodBehindFacade("Sample");
    }
  }
}

namespace DesignPatterns.FacadePattern {
  public class FacadePatternSample : IDesignPatternSample {
    public void ShowSample() {
      var facade = new Facade();
      Facade.UseMethodBehindFacade("Sample");
    }
  }
}

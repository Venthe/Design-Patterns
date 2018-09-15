using System;

namespace DesignPatterns.Observer.WithSubscriber
{
   public static class SampleTransformations
   {
      public static dynamic ToUpper(dynamic value) => value.ToString().ToUpper();
      public static Func<dynamic, dynamic> Log() => VoidFunctionToNull(Console.WriteLine);

      public static Func<dynamic, dynamic> Map(Func<dynamic, dynamic> transformation) => value => transformation(value);

      public static Func<dynamic, dynamic> Tap(Action<dynamic> sideEffect) => Tap(VoidFunctionToNull(sideEffect));

      public static Func<dynamic, dynamic> Tap(Func<dynamic, dynamic> sideEffect) => value =>
      {
         sideEffect(value);
         return value;
      };

      private static Func<dynamic, dynamic> VoidFunctionToNull(Action<dynamic> sideEffect) => val =>
      {
         sideEffect(val);
         return null;
      };
   }
}

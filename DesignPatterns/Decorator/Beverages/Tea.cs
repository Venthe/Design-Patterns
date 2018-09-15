using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Beverages
{
   public class Tea : AbstractBeverage
   {
      public override int GetPrice() => 5;
   }
}

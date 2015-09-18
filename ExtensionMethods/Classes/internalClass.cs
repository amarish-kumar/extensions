using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Classes
{
    internal abstract class baseClass
    {
        public virtual string getFirstName()
        {
            return "rahul";
        }

        protected virtual string getSecondName()
        {
            return "sahay";
        }
    }
  internal class internalClass:baseClass
    {
      public string getFirstValue()
      {
          return "extension";
      }
      internal class secondClass:baseClass
      {
          public override string getFirstName()
          {
              return "John";
          }

          internal string getSecondValue()
          {
              return "smith";
          }
          private class thirdClass
          {
              private string getThirdValue()
              {
                  return "dave";
              } 
          }
      }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Classes
{
    internal abstract class class0
    {
        public virtual string getString0()
        {
            return "abc";
        }

        protected virtual string getString00()
        {
            return "abcd";
        }
    }
  internal class internalClass:class0
    {
      public string getFirstValue()
      {
          return "a";
      }
      internal class secondClass:class0
      {
          public override string getString0()
          {
              return "xyz";
          }

          internal string getSecondValue()
          {
              return "b";
          }
          private class thirdClass
          {
              private string getThirdValue()
              {
                  return "c";
              } 
          }
      }
    }
}

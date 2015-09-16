using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Classes
{
   internal  static class internalClassExtensions
    {
       public static string getString0Upper(this class0 objClass)
       {
           return objClass.getString0().ToUpper();
       }
       public static string getFirstValueUpper(this internalClass objClass)
       {
           return objClass.getFirstValue().ToUpper();
       }

       public static string getSecondValueUpper(this internalClass.secondClass objSecondClass)
       {
           return objSecondClass.getSecondValue().ToUpper();
       }

       //Cannot access private class as shown below
       /*public static string getThirdValueUpper(this internalClass.secondClass.thirdClass )
       {
           
       }*/

       //hence, if we really need to extend inaccessible class, we can extend object
       public static string getThirdValueUpper(this object obj)
       {
           var upper = string.Empty;
           var type = typeof (internalClass.secondClass).GetNestedType("thirdClass", BindingFlags.NonPublic);
           if (obj.GetType() == type)
           {
               //Now, I gain the access of private method as welll
               var method = type.GetMethod("getThirdValue", BindingFlags.NonPublic | BindingFlags.Instance);
               var result = method.Invoke(obj, null) as string;
               upper = result.ToUpper();
           }
           return upper;
       }
    }
}

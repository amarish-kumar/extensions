using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.ExceptionExtension
{
   public static class ExceptionExtension
    {
       public static string CompleteMessage(this Exception ex)
       {
           var builder = new StringBuilder();
           while (ex != null)
           {
               builder.AppendFormat("{0}{1}", ex.Message, Environment.NewLine);
               ex = ex.InnerException;
           }
           return builder.ToString();
       }
    }
}

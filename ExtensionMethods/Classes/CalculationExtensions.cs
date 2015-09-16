using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Classes
{
    public static class CalculationExtensions
    {
        public static double getPrecisionElapsedTime(this Calculations calculations)
        {
            //Fetching private field value via reflection
            var fieldinfo = typeof(Calculations).GetField("_startedAt", BindingFlags.Instance | BindingFlags.NonPublic);
            var startedAt = (DateTime)fieldinfo.GetValue(calculations);
            return new TimeSpan(DateTime.Now.Ticks - startedAt.Ticks).TotalSeconds;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExtensionMethods.Extensions
{
    public static class LegacyExtensions
    {
        //Extension method to check 20Century date or 21st
        public static string ToLegacyDate(this DateTime dateTime)
        {
            return dateTime.Year > 1930 ? dateTime.ToString("1yyMMdd") :
            dateTime.ToString("0yyMMdd");
        }

        //Extension method to revere the name
        public static string ToLegacyName(this string name)
        {
            var names = name.ToUpper().Split(' ');
            return names[1] + ", " + names[0];
        }

        //Extension Method for XML Date Time
        public static string ToXMLDateTime(this DateTime dateTime)
        {
            return XmlConvert.ToString(dateTime, XmlDateTimeSerializationMode.Utc);
        }
    }
}

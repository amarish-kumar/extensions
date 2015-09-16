using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods.Extensions;
using ExtensionMethods.Intefaces;

namespace ExtensionMethods.Implementations
{
    public abstract class APIDataSource
    {
        public string name = "API";
    }
    public class APIReferenceDataSource : APIDataSource
    {
        public IEnumerable<ReferenceDataItem> getItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem {Code = "abc", Description = "from API-1"},
                new ReferenceDataItem {Code = "def", Description = "from API-2"}
            };
        }
        
    }
}

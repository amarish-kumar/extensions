using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Intefaces
{
   public interface IReferenceDataItem
   {
       IEnumerable<IReferenceDataItem> getItems();
   }
}

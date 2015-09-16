using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Classes
{
   public sealed class Calculations
    {
       public Guid Id { get; private set; }
       private DateTime _startedAt;

       public string ProcessName { get; set; }

       public Calculations()
       {
           Id = Guid.NewGuid();
       }

       //Start time set
       public void Start()
       {
           _startedAt = DateTime.Now;
       }

       public int GetElapsedTime()
       {
           return (int) Math.Round(new TimeSpan(DateTime.Now.Ticks - _startedAt.Ticks).TotalSeconds, 0);
       }
    }

}

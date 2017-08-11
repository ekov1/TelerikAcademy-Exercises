using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School_Classes
{
    class Worker : Human
    {
        #region Properties
        public decimal WeekSalary {get; set;}
        public int WorkHoursPerDay { get; set; }
        #endregion

        #region Methods
        public decimal MoneyPerHour()
        {
            return 0;
        }
        #endregion
    }
}

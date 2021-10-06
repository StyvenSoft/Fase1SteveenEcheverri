using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1SteveenEcheverri
{
    class Employee
    {
        public int CalculateEarnedSalary(int workingdDays, int DaySalaryValue)
        {
            int totalAccrued = DaySalaryValue * workingdDays;
            return totalAccrued;
        }
    }
}

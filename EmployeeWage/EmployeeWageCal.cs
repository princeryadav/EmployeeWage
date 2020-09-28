using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeeWageCal
    {
        private readonly int IS_FULL_TIME;
        private readonly int EMP_RAT_PER_HOUR;
        public EmployeeWageCal()
        {
            this.IS_FULL_TIME = 1;
            this.EMP_RAT_PER_HOUR = 20;
        }
        public void CalculateEmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            int empHrs;
            if (empCheck == this.IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            int empWage = empHrs * EMP_RAT_PER_HOUR;
            Console.WriteLine("Emp Wage : {0}", empWage);
        }
    }
}

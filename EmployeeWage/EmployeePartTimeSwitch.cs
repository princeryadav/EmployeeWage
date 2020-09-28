using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeePartTimeSwitch
    {
        private const int IS_PART_TIME = 1;
        private const int IS_FULL_TIME = 2;
        private const int EMP_RATE_PER_HOUR = 20;
        public void AddPartTimeEmployee()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            int empHrs;
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : {0}", empWage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeePartTime
    {
        public void AddPartTimeEmployee()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            int empHrs;
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : {0}", empWage);
        }
    }
}

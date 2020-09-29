using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeeWorkingDay
    {
        // All constant.
        private const int IS_PART_TIME = 1;
        private const int IS_FULL_TIME = 2;
        private const int EMP_RATE_PER_HOUR = 20;
        private const int NUM_OF_WORKING_DAY = 20;
        public void NumberOfWorkingDay()
        {
            // All local.
            int empHrs;
            int totalNumOfWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAY; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                totalNumOfWage += empWage;
                Console.WriteLine("Emp Wage : {0}", empWage);
            }
            Console.WriteLine("Total num of Wage : {0}", totalNumOfWage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeeMaxDay
    {
        private const int IS_PART_TIME = 1;
        private const int IS_FULL_TIME = 2;
        private const int EMP_RATE_PER_HOUR = 20;
        private const int MAX_NUM_OF_WORKING_DAY = 20;
        private const int MAX_NUM_OF_WORKING_HOUR = 100;

        public void NumberOfMaxWorkingDay()
        {
            int empHrs;
            int totalNumOfWage = 0;
            int totalNumOfHrs = 0;
            int totalNumOfDay = 0;
            while (totalNumOfHrs <= MAX_NUM_OF_WORKING_HOUR && totalNumOfDay < MAX_NUM_OF_WORKING_DAY)
            {
                totalNumOfDay++;
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
                totalNumOfHrs += empHrs;
            }
            totalNumOfWage = totalNumOfHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total num of Wage : {0}", totalNumOfWage);
        }
    }
}

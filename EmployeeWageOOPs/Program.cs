using System;

namespace EmployeeWageOOPs
{
    class Program
    {
        // All constant.
        private const int IS_PART_TIME = 1;
        private const int IS_FULL_TIME = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Emp computation!");
            ComputeEmpWage("DMART", 20, 20, 100);
            ComputeEmpWage("JIO De dana dan", 20, 20, 100);
        }

        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
        {
            // All Local.
            int empHrs;
            int totalNumOfWage = 0;
            int totalNumOfHrs = 0;
            int totalNumOfDay = 0;
            // Check for condition.
            while (totalNumOfHrs <= maxHourPerMonth && totalNumOfDay < numOfWorkingDay)
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
            totalNumOfWage = totalNumOfHrs * empRatePerHour;
            Console.WriteLine("Total num of Wage for company : {0} is {1}", company, totalNumOfWage);
            return totalNumOfWage;
        }
    }
}

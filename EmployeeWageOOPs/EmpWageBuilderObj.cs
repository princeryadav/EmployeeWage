using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageOOPs
{
    class EmpWageBuilderObj
    {
        // All constant.
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDay;
        private int maxHourPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObj(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDay = numOfWorkingDay;
            this.maxHourPerMonth = maxHourPerMonth;
        }

        public void ComputeEmpWage()
        {
            // All Local.
            int empHrs;
            int totalNumOfHrs = 0;
            int totalNumOfDay = 0;
            // Check for condition.
            while (totalNumOfHrs <= this.maxHourPerMonth && totalNumOfDay < this.numOfWorkingDay)
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
            totalEmpWage = totalNumOfHrs * this.empRatePerHour;
            Console.WriteLine("Total num of Wage for company : {0} is {1}", company, totalEmpWage);
        }

        public string toString()
        {
            return "Total num of Wage for company : " + this.company + " is " + this.totalEmpWage;
        }
    }
}

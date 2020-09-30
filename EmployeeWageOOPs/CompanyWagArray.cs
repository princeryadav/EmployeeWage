using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageOOPs
{
    class CompanyWagArray
    {
        // All constant.
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWag[] companyEmpsArray;

        public CompanyWagArray()
        {
            this.companyEmpsArray = new CompanyEmpWag[5];
        }

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
        {
            this.companyEmpsArray[this.numOfCompany] = new CompanyEmpWag(company, empRatePerHour, numOfWorkingDay, maxHourPerMonth);
            this.numOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < this.numOfCompany; i++)
            {
                companyEmpsArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpsArray[i]));
                Console.WriteLine(this.companyEmpsArray[i].toString());
            }
        }

        public int ComputeEmpWage(CompanyEmpWag companyEmp)
        {
            // All Local.
            int empHrs;
            int totalNumOfHrs = 0;
            int totalNumOfDay = 0;
            // Check for condition.
            while (totalNumOfHrs <= companyEmp.maxHourPerMonth && totalNumOfDay < companyEmp.numOfWorkingDay)
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
            return totalNumOfHrs * companyEmp.empRatePerHour;
        }
    }
}

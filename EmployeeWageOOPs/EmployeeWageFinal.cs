using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageOOPs
{
    public class EmpWagBuilder : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWag> list;
        private Dictionary<string, CompanyEmpWag> keyValues;

        public EmpWagBuilder()
        {
            this.list = new LinkedList<CompanyEmpWag>();
            this.keyValues = new Dictionary<string, CompanyEmpWag>();
        }

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
        {
            CompanyEmpWag empWag = new CompanyEmpWag(company, empRatePerHour, numOfWorkingDay, maxHourPerMonth);
            list.AddLast(empWag);
            keyValues.Add(company, empWag);
        }

        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWag item in list)
            {
                item.setTotalEmpWage(ComputeEmpWage(item));
                Console.WriteLine(item.toString());
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

        public int GetTotalWage(string comany)
        {
            return this.keyValues[comany].totalEmpWage;
        }
    }
}

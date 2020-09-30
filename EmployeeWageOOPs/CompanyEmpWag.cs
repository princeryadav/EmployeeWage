using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageOOPs
{
    public class CompanyEmpWag
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDay;
        public int maxHourPerMonth;
        public int totalEmpWage;
        public CompanyEmpWag(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDay = numOfWorkingDay;
            this.maxHourPerMonth = maxHourPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total num of Wage for company : " + this.company + " is " + this.totalEmpWage;
        }
    }
}

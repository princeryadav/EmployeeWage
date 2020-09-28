using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Master Branch
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            // UC1
            EmployeePresOrAbs employeePresOrAbs = new EmployeePresOrAbs();
            employeePresOrAbs.IsEmployeePresentOrAbsent();
            // UC2
            EmployeeWageCal wageCal = new EmployeeWageCal();
            wageCal.CalculateEmpWage();
            // UC3
            EmployeePartTime partTime = new EmployeePartTime();
            partTime.AddPartTimeEmployee();
            // UC4
            EmployeePartTimeSwitch partTimeSwitch = new EmployeePartTimeSwitch();
            partTimeSwitch.AddPartTimeEmployee();
            // UC5
        }
    }
}

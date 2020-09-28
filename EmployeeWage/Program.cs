using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            EmployeePresOrAbs employeePresOrAbs = new EmployeePresOrAbs();
            employeePresOrAbs.IsEmployeePresentOrAbsent();
            EmployeeWageCal wageCal = new EmployeeWageCal();
            wageCal.CalculateEmpWage();
            EmployeePartTime partTime = new EmployeePartTime();
            partTime.AddPartTimeEmployee();
        }
    }
}

using System;

namespace EmployeeWageOOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Emp computation!");
            EmpWagBuilder wageList = new EmpWagBuilder();
            wageList.AddCompanyEmpWage("DMART", 20,20,100);
            wageList.AddCompanyEmpWage("TATA", 20, 20, 100);
            wageList.ComputeEmpWage();
            Console.WriteLine("{0}", wageList.GetTotalWage("DMART"));
        }
    }
}

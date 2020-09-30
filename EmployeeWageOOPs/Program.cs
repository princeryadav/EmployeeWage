using System;

namespace EmployeeWageOOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Emp computation!");
            CompanyWagArray wagArray = new CompanyWagArray();
            wagArray.AddCompanyEmpWage("DMART", 20,20,100);
            wagArray.AddCompanyEmpWage("TATA", 20, 20, 100);
            wagArray.ComputeEmpWage();
        }
    }
}

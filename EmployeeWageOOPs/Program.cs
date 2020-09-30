using System;

namespace EmployeeWageOOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Emp computation!");
            EmpWageBuilderObj builderObj = new EmpWageBuilderObj("DMART", 20,20,100);
            builderObj.ComputeEmpWage();
            string result =builderObj.toString();
            Console.WriteLine(result);
            EmpWageBuilderObj builderObj1 = new EmpWageBuilderObj("TATA", 20, 20, 100);
            builderObj1.ComputeEmpWage();
            Console.WriteLine(builderObj1.toString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeePresOrAbs
    {
        readonly int IS_FULL_TIME;
        public EmployeePresOrAbs()
        {
            this.IS_FULL_TIME = 1;
        }
        public void IsEmployeePresentOrAbsent()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == this.IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Emplpyee is Absent");
            }
        }
    }
}

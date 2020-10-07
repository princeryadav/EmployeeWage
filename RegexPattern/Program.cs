using System;

namespace RegexPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Pattern Demo!");
            RegexPatternMatch regex = new RegexPatternMatch();
            //bool result =regex.ValidatePinCode("1abc1.1xyz@1gmail.co.in");
            bool result =regex.ValidateEmail("1abc1.1xyz@1gmail.co.in");
            Console.WriteLine(result);
        }
    }
}

using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 1) Console.WriteLine("employee is present");
            else Console.WriteLine("employee is absent");
        }
    }
}

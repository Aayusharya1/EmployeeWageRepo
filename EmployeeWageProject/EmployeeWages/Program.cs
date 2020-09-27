using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            for (int i = 0; i < 20; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 0:
                        empHrs = 0;
                        break;
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;
                }

                empWage += empHrs * EMP_RATE_PER_HOUR;
            }
            Console.WriteLine("Emp Wage: " + empWage);

        }
    }
}

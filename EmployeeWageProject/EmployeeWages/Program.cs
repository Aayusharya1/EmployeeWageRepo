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
            int totHrs = 0;
            int totDays = 0;

            for (int i = 0; i < 30; i++)
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
                        totHrs += empHrs;
                        totDays += 1;
                        break;
                    case 2:
                        empHrs = 8;
                        totHrs += empHrs;
                        totDays += 1;
                        break;
                }
                if (totHrs <= 100 && totDays <= 20)
                    empWage += empHrs * EMP_RATE_PER_HOUR;
                else break;
            }

            Console.WriteLine("Emp Wage: " + empWage);
        }
    }
}

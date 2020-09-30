using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("employee wage" + MaximumWageComputation());
        }

        static int MaximumWageComputation() 
        {
            int IS_FULL_TIME = 0;
            int EMP_RATE_PER_HOUR = 20;
            int totHrs = 0;
            int totDays = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME) 
            {
                Console.WriteLine("full time employee");
                while (totHrs < 100 && totDays < 20) 
                {
                    totDays += 1;
                    totHrs += 8;
                
                }


            }

            else 
            {
                Console.WriteLine("part time employee");
                while (totHrs < 100 && totDays < 20)
                {
                    totDays += 1;
                    totHrs += 4;

                }
            }

            return totHrs * EMP_RATE_PER_HOUR;
        }
    }
}

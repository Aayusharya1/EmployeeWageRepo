using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWageBuilder
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int EMP_RATE_PER_HOUR;
        private int MAX_WORK_DAYS;
        private int MAX_WORK_HOURS;

        public EmployeeWageBuilder(string company, int empRatePerHr, int noOfWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            EMP_RATE_PER_HOUR = empRatePerHr;
            MAX_WORK_DAYS = noOfWorkingDays;
            MAX_WORK_HOURS = maxWorkingHrs;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Employee wage: " + EmployeeWageComputation("Microsoft", 20, 20, 100));
            Console.WriteLine("Employee wage: " + EmployeeWageComputation("Amazon", 10, 25, 200));
        }
        static int EmployeeHours()
        {
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            return empHrs;
        }
        static int EmployeeWageComputation(string company, int EMP_RATE_PER_HOUR, int MAX_WORK_DAYS, int MAX_WORK_HOURS)
        {
            int monthlySalary = 0;
            int totalWorkHrs = 0;
            int totalWorkDays = 0;
            while (totalWorkHrs <= MAX_WORK_HOURS && totalWorkDays < MAX_WORK_DAYS)
            {
                totalWorkDays++;
                int empHrs = EmployeeHours();
                totalWorkHrs += empHrs;
                Console.WriteLine("Working day: " + totalWorkDays + " Working Hours: " + empHrs);
            }
            monthlySalary = totalWorkHrs * EMP_RATE_PER_HOUR;
            return monthlySalary;
        }
    }
}

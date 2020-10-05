using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeWageBuilder empWageBuilder = new EmployeeWageBuilder();
            empWageBuilder.AddCompanyEmpWage("Microsoft", 20, 20, 100);
            empWageBuilder.AddCompanyEmpWage("Amazon", 10, 25, 200);
            empWageBuilder.ComputeEmpWage();
        }
    }
}
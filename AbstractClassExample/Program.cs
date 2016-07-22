using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClassExample;

namespace AbstractClassExample
{
    class Program
    {
        public static void Main()
        {
           
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.ID = 101;
            fte.FirstName = "John";
            fte.LastName = "Doe";
            fte.AnnualSalary = 50000;

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.WriteLine("-----------------------------------------------");


            ContractEmployee cte = new ContractEmployee();
            cte.ID = 101;
            cte.FirstName = "Sara";
            cte.LastName = "Dahms";
            cte.TotalHoursWorked = 160;
            cte.HourlyPay = 50;

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
            Console.WriteLine("-----------------------------------------------");
        }

    }

}

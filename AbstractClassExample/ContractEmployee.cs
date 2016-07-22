﻿namespace AbstractClassExample
{
    public class ContractEmployee : BaseEmployee
    {

        public int HourlyPay { get; set; }
        public int TotalHoursWorked { get; set; }

        public override int GetMonthlySalary()
        {
            return this.TotalHoursWorked * this.HourlyPay;
        }
    }
}

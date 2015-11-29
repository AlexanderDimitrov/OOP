using System;
using System.Text;



namespace Problem1.Prop
{
    public class Worker:Human
    {
        private const int workDaysPerWeek = 5;
        

        public Worker(string firstName,string secondName,decimal weekSalary,int workHoursPerDay) :base(firstName,secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }
        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (decimal)(workDaysPerWeek * this.WorkHoursPerDay);
        }
             
    }
}

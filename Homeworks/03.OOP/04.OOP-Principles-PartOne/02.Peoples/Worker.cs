using System;
using System.Text;
// 2.2 Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour()
//     that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.

class Worker : Human
{
    private const int workdays = 5;

    public decimal WeekSalary { get; set; }
    public decimal WorkHoursPerDay { get; set; }

    public Worker(string name, string family, decimal salary, decimal workHours)
        : base(name, family)
    {
        this.WeekSalary = salary;
        this.WorkHoursPerDay = workHours;
    }

    public decimal MoneyPerHour()
    {
        return WeekSalary / workdays / WorkHoursPerDay;
    }

    public override string ToString()
    {
        var print = new StringBuilder();
        print.AppendFormat("Name: {0} {1} \r\nSalary: {2} \r\nWork hours per day {3} \r\nMoney per hour {4}",
                                          firstName, lastName, WeekSalary, WorkHoursPerDay, MoneyPerHour());

        return print.ToString();
    }
}
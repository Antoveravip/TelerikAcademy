namespace Humans
{
    using System;

    class Worker : Human
    {
        // --- FIELDS --- //
        private byte workHoursPerDay;
        private decimal weekSalary;
        private const int WorkdaysInWeek = 5;

        // --- PROPERTIES --- //
        public byte WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value <= 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("The work hours is not proper!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Not correct value for week salary!");
                }
                this.weekSalary = value;
            }
        }

        // --- CONSTRUCTORS --- //
        public Worker(string firstName, string lastName, byte workHoursPerDay, decimal weekSalary)
            : base(firstName, lastName)
        {
            this.workHoursPerDay = workHoursPerDay;
            this.weekSalary = weekSalary;

        }

        // --- METHODS --- //
        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = Math.Round((this.WeekSalary / WorkdaysInWeek) / this.WorkHoursPerDay, 2);
            return moneyPerHour;
        }
    }
}
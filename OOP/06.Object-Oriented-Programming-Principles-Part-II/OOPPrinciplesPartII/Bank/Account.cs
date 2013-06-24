namespace Bank
{
    using System;

    public abstract class Account
    {
        // --- FIELDS --- //
        private Customer owner;
        protected decimal balance;
        private decimal interestMonthlyRate;
        protected IInterestCalculatorable interestRateCalculator;

        // --- PROPERTIES --- //
        public Customer Owner { get { return this.owner; } }

        public decimal Balance
        {
            get { return this.balance; }
            private set { this.balance = value; }
        }

        public decimal InterestMonthlyRate
        {
            get { return interestMonthlyRate; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Interest rate must be positive number");
                }
                this.interestMonthlyRate = value;
            }
        }

        // --- CONSTRUCTORS --- //
        protected Account(Customer owner, decimal balance, decimal interestMonthlyRate)
        {
            this.owner = owner;
            this.Balance = balance;
            this.InterestMonthlyRate = interestMonthlyRate;
        }

        // --- METHODS --- //
        public decimal CalculateInterest(sbyte months)
        {
            if (months <= 0)
            {
                throw new ArgumentOutOfRangeException("The months periond must be positive integer");
            }
            decimal result = (this.interestRateCalculator.CalculateInterest() / this.interestRateCalculator.MonthsPeriod) * months;
            return result;            
        }
    }
}
namespace Bank
{
    using System;

    public class LoanAccountInterestCalc : IInterestCalculatorable
    {
        // --- FIELDS --- //
        private decimal principal;
        private int monthsPeriodInterestFree;
        private decimal interestMonthlyRate;
        private int monthsPeriod;

        // --- PROPERTIES --- //
        public decimal Principal
        {
            get { return principal; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Principal must be positive value.");
                }
                principal = value;
            }
        }

        public int MonthsPeriodInterestFree
        {
            get { return monthsPeriodInterestFree; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Monts period with interest free must be positive number.");
                }
                monthsPeriodInterestFree = value;
            }
        }

        public decimal InterestMonthlyRate
        {
            get { return interestMonthlyRate; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Interest monthly rate must be positive number");
                }
                interestMonthlyRate = value;
            }
        }

        public int MonthsPeriod
        {
            get { return monthsPeriod; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The months periond must be positive integer");
                }
                monthsPeriod = value;
            }
        }

        // --- CONSTRUCTORS --- //
        public LoanAccountInterestCalc(Customer owner, decimal principal, decimal interestMonthlyRate, int monthsPeriod)
        {
            if (owner is Individual)
            {
                this.MonthsPeriodInterestFree = 4;
            }
            else
            {
                this.MonthsPeriodInterestFree = 3;
            }

            this.Principal = principal;
            this.InterestMonthlyRate = interestMonthlyRate;
            this.MonthsPeriod = monthsPeriod;
        }

        // --- METHODS --- //
        public decimal CalculateInterest()
        {
            if (this.monthsPeriod <= this.monthsPeriodInterestFree)
            {
                throw new ArgumentOutOfRangeException("The calculated months period must be greater than the period with interest free.");
            }
            decimal result = ((this.interestMonthlyRate / 100) * this.principal) * (this.monthsPeriod - this.monthsPeriodInterestFree);
            return result;
        }
    }
}
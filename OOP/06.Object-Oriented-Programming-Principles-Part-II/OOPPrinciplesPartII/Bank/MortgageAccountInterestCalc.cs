namespace Bank
{
    using System;

    public class MortgageAccountInterestCalc: IInterestCalculatorable
    {
        // --- FIELDS --- //
        private decimal principal;
        private int reducedMonthsPeriodInterest;
        private decimal reducedInterestMonthlyRate;
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

        public int ReducedMonthsPeriodInterest
        {
            get { return reducedMonthsPeriodInterest; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Reduced months period with interest free must be positive number.");
                }
                reducedMonthsPeriodInterest = value;
            }
        }

        public decimal ReducedInterestMonthlyRate
        {
            get { return reducedInterestMonthlyRate; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Reduced interest monthly rate must be positive number");
                }
                reducedInterestMonthlyRate = value;
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
            get
            {
                return monthsPeriod;
            }
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
        public MortgageAccountInterestCalc(Customer owner, decimal principal, decimal interestMonthlyRate, int monthsPeriod)
        { 
            if (owner is Individual)
            {
                this.ReducedMonthsPeriodInterest = 6;
                this.ReducedInterestMonthlyRate = 0;
            }
            else
            {
                this.ReducedMonthsPeriodInterest = 12;
                this.ReducedInterestMonthlyRate = interestMonthlyRate / 3;
            }
            this.Principal = principal;
            this.InterestMonthlyRate = interestMonthlyRate;
            this.MonthsPeriod = monthsPeriod;
        }

        // --- METHODS --- //
        public decimal CalculateInterest()
        {
            if (this.monthsPeriod <= this.reducedMonthsPeriodInterest)
            {
                throw new ArgumentException("The months period must be greater than the reduced interest period.");
            }
            decimal reduced = (this.reducedInterestMonthlyRate / 100) * this.principal * this.reducedMonthsPeriodInterest;
            decimal regular = (this.interestMonthlyRate / 100) * this.principal * (this.monthsPeriod - this.reducedMonthsPeriodInterest);
            decimal result = reduced + regular;

            return result;                
        }
    }
}
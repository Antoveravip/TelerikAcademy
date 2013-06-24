namespace Bank
{
    using System;

    public class DepositAccountInterestCalc : IInterestCalculatorable
    {
        // --- FIELDS --- //
        private decimal principal;
        private decimal minInterestPrincipal;
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

        public decimal MinInterestPrincipal
        {
            get { return minInterestPrincipal; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Minimum interest principal must be positive value.");
                }
                minInterestPrincipal = value;
            }
        }

        public decimal MonthlyInterestRate
        {
            get { return interestMonthlyRate; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Interest rate must be positive number");
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
        public DepositAccountInterestCalc(decimal principal, decimal interestMonthlyRate, int monthsPeriod)
        {
            this.Principal = principal;
            this.MinInterestPrincipal = 1000;
            this.MonthlyInterestRate = interestMonthlyRate;
            this.MonthsPeriod = monthsPeriod;
        }

        // --- METHODS --- //
        public decimal CalculateInterest()
        {
            if (this.principal < this.MinInterestPrincipal)
            {
                return 0;
            }
            decimal result = ((this.interestMonthlyRate / 100) * this.principal) * this.monthsPeriod;

            return result;
        }
    }
}
namespace Bank
{
    using System;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer owner, decimal balance, decimal interestMonthlyRate, int monthsPeriod)
            : base(owner, balance, interestMonthlyRate)
        {
            this.interestRateCalculator = new LoanAccountInterestCalc(owner, balance, interestMonthlyRate, monthsPeriod);
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }
    }
}
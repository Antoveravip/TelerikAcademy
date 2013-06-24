namespace Bank
{
    using System;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer owner, decimal balance, decimal interestMonthlyRate, int monthsPeriod)
            : base(owner, balance, interestMonthlyRate)
        {
            this.interestRateCalculator = new MortgageAccountInterestCalc(owner, balance, interestMonthlyRate, monthsPeriod);
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }
    }
}
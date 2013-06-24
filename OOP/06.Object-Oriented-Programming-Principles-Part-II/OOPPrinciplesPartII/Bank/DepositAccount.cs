namespace Bank
{
    using System;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer owner, decimal balance, decimal interestMonthlyRate, int monthsPeriod)
            : base(owner, balance, interestMonthlyRate)
        {
            this.interestRateCalculator = new DepositAccountInterestCalc(balance, interestMonthlyRate, monthsPeriod);
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (this.balance < amount)
            {
                throw new ArgumentNullException("Not enough money!");
            }
            this.balance -= amount;
        }
    }
}
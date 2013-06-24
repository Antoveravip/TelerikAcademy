namespace Bank
{
    using System;
    using System.Globalization;
    using System.Threading;

    class BankDemo
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            Customer depositAccountCustomer = new Individual(
                "8803125040",
                "Kamen",
                "Donchev",
                "Sofia, Hristo Botev 16",
                "359 888 999 777");

            Account depositAccount = new DepositAccount(
                depositAccountCustomer,
                1200M,
                0.50M,
                12);

            Customer loanAccountCustomer = new Company(
                "BG169120188",
                "Stroikoplast",
                "Varna, Vladislav Varnenchik 120",
                "+359 899 777 888");

            Account loanAccount = new LoanAccount(
                loanAccountCustomer,
                5000M,
                1.00M,
                6);

            Customer mortgageAccountCustomer = new Individual(
                "7512123020",
                "Plamen",
                "Kamenov",
                "Plovdiv, Marica 17",
                "+359 896 172 852");

            Account mortgageAccount = new MortgageAccount(
                mortgageAccountCustomer,
                250000,
                1.50M,
                60);

            decimal depositInterest = depositAccount.CalculateInterest(12);
            Console.WriteLine("Deposit account interest: {0:C2}", depositInterest);

            (depositAccount as IDepositable).Deposit(485.95M);
            (depositAccount as IWithdrawable).Withdraw(390.50M);

            Console.WriteLine("Deposit account balance: {0:C2}", depositAccount.Balance);

            decimal loanInterest = loanAccount.CalculateInterest(6);
            Console.WriteLine("Loan account interest: {0:C2}", loanInterest);

            decimal mortgageInterest = mortgageAccount.CalculateInterest(60);
            Console.WriteLine("Mortgage loan account interest: {0:C2}", mortgageInterest);
        }
    }
}
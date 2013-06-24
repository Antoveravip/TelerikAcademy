namespace Bank
{
    public interface IInterestCalculatorable
    {
        int MonthsPeriod { get; }

        decimal CalculateInterest();
    }
}
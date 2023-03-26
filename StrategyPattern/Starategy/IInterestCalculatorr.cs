namespace StrategyPattern.Starategy
{
    public interface IInterestCalculator
    {
        double Calculate();
    }

    public class HighSessionIntresest : IInterestCalculator
    {
        public double Calculate()
        {
            return 0;
        }
    }


    public class LowSessionIntresest : IInterestCalculator
    {
        public double Calculate()
        {
            return 0;
        }
    }
}

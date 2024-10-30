using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BozhukovVP.Sprint3.Task2.V10.Lib
{
    public class DataService : ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            double i = startValue;
            do
            {
                MultiplySeries = MultiplySeries * (1+1/(i+1));
                i++;
            } while (i <= stopValue);
            return Math.Round(MultiplySeries, 3);
        }
    }
    
}

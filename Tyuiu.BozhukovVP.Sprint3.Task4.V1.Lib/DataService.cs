using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BozhukovVP.Sprint3.Task4.V1.Lib
{
    public class DataService : ISprint3Task4V1
    {
        public double Calculate(int startValue, int stopValue)
        {
            int i2 = stopValue;
            double sum = 0;
            for (int i = startValue; i < i2; i++)
            {
                if (i == 0)
                {
                    break;
                }
                sum = sum + (Math.Sin(i) / i);

            }
            return Math.Round(sum, 3);
        }
    }
}

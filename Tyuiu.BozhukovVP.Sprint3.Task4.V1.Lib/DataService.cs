﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BozhukovVP.Sprint3.Task4.V1.Lib
{
    public class DataService : ISprint3Task4V1
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                    continue;
                else
                    res = res + (Math.Sin(x)/x);
            }
            return Math.Round(res, 3);
        }
    }
}
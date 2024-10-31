using Tyuiu.BozhukovVP.Sprint3.Task5.V15.Lib;
namespace Tyuiu.BozhukovVP.Sprint3.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = -13.768;
            Assert.AreEqual(wait, res);
        }
    }
}
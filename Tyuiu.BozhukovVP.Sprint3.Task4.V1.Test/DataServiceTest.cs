using Tyuiu.BozhukovVP.Sprint3.Task4.V1.Lib;
namespace Tyuiu.BozhukovVP.Sprint3.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 2.924;
            Assert.AreEqual(wait, res);
        }
    }
}
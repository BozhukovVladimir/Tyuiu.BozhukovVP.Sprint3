using Tyuiu.BozhukovVP.Sprint3.Task7.V2.Lib;
namespace Tyuiu.BozhukovVP.Sprint3.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            var res = ds.GetMassFunction(-5, 5);
            var str = string.Join(" ", res);
            Assert.AreEqual(str, "59.49,38.47,-2.81,-19.67,-8.42,0.57,-6.3,-20.14,-3.51,38.13,59.6");
        }
    }
}
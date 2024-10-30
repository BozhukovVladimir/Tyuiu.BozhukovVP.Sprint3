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
            Assert.AreEqual(str, "13,81 11,87 9,87 7,74 5,36 2,5 0 0,79 -1,75 -3,78 -5,71");
        }
    }
}
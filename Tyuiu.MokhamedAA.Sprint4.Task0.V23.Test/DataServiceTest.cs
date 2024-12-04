using Tyuiu.MokhamedAA.Sprint4.Task0.V23.Lib;
namespace Tyuiu.MokhamedAA.Sprint4.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int res = ds.GetMultOddArrEl(nums);
            Assert.AreEqual(99225, res);
        }
    }
}
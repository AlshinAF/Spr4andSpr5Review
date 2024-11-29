using Tyuiu.AlshinAF.Sprint4.Rev.V1.Lib;
namespace Tyuiu.AlshinAF.Sprint4.Rev.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 3;
            int columns = 3;
            int[,] mrex = new int[rows, columns];
            string str = "135792468";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
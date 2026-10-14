using Tyuiu.PonkratevMM.Sprint2.Task4.V7.Lib;
namespace Tyuiu.PonkratevMM.Sprint2.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 22;
            double y = 9;
            double res = ds.Calculate(x, y);
            double wait = 1.097;
            Assert.AreEqual(wait, res);



        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 1026.040;
            Assert.AreEqual(wait, res);


        }
    }
}

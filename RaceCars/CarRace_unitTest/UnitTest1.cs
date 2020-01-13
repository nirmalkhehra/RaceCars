using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaceCars.Business.AllPunters;
namespace CarRace_unitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Punter[] myPunter = new Punter[2];
            int Id = 1;
            string name = "Clark";
            myPunter[1] = Factory.GetAPunter(Id);

            Assert.AreEqual(name, myPunter[1].PunterName);
        }
    }
}

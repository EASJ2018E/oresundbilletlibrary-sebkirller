using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using ØresundbroenLibrary;

namespace Tests
{
    [TestClass]
    public class UnitTestMCOb
    {
        [TestMethod]
        public void TestMethodMCObPrisUdenBrobizz()
        {
            MCOb mco = new MCOb();
            var actualResult = (double) mco.Pris();

            var expectedResult = 210;

            Assert.AreEqual(expectedResult, actualResult,
                "Test failed! The actual result is not the same as the expected result");
        }

        [TestMethod]
        public void TestMethodMCObPrisMedBrobizz()
        {
            MCOb mco = new MCOb { Brobizz = true };
            var actualResult = (double) mco.Pris();

            var expectedResult = 73;

            Assert.AreEqual(expectedResult, actualResult,
                "Test failed! The actual result is not the same as the expected result");
        }

        [TestMethod]
        public void TestMethodMCObKøretøj()
        {
            MCOb mco = new MCOb();
            var actualResult = mco.Køretøj();

            var expectedResult = "Øresund MC";

            Assert.AreEqual(expectedResult, actualResult,
                "Test failed! The actual result is not the same as the expected result");
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using ØresundbroenLibrary;

namespace Tests
{
    [TestClass]
    public class UnitTestBilOb
    {
        [TestMethod]
        public void TestMethodBilObPrisUdenBrobizz()
        {
            BilOb bo = new BilOb();
            var actualResult = (double) bo.Pris();

            var expectedResult = 410;

            Assert.AreEqual(expectedResult, actualResult,
                "Test failed! The actual result is not the same as the expected result");
        }

        [TestMethod]
        public void TestMethodBilObPrisMedBrobizz()
        {
            BilOb bo = new BilOb { Brobizz = true };
            var actualResult = (double) bo.Pris();

            var expectedResult = 161;

            Assert.AreEqual(expectedResult, actualResult,
                "Test failed! The actual result is not the same as the expected result");
        }

        [TestMethod]
        public void TestMethodBilObKøretøj()
        {
            BilOb bo = new BilOb();
            var actualResult = bo.Køretøj();

            var expectedResult = "Øresund Bil";

            Assert.AreEqual(expectedResult, actualResult,
                "Test failed! The actual result is not the same as the expected result");
        }
    }
}

using ClassLibraryUnitTest;
namespace Maths
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void Transaction_TestAddition()
        {
            ClassLibraryUnitTest.Math math = new ClassLibraryUnitTest.Math();
            Single a = 1f;
            Single startSaldo = math.Saldo;
            Single expectedResult = startSaldo + a;
            math.Transaction("+", a);
            Single result = math.Saldo;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Transaction_TestDifference()
        {
            ClassLibraryUnitTest.Math math = new ClassLibraryUnitTest.Math();
            Single a = 1f;
            Single startSaldo = math.Saldo;
            Single expectedResult = startSaldo - a;
            math.Transaction("-", a);
            Single result = math.Saldo;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Transaction_TestAdditionDecimal()
        {
            ClassLibraryUnitTest.Math math = new ClassLibraryUnitTest.Math();
            Single a = 1.00004f;
            Single startSaldo = math.Saldo;
            Single expectedResult = startSaldo + a;
            math.Transaction("+", a);
            Single result = math.Saldo;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Transaction_TestDifferenceDecimal()
        {
            ClassLibraryUnitTest.Math math = new ClassLibraryUnitTest.Math();
            Single a = 1.00004f;
            Single startSaldo = math.Saldo;
            Single expectedResult = startSaldo - a;
            math.Transaction("-", a);
            Single result = math.Saldo;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Transaction_TestDifferenceBelowZero() 
        {
            ClassLibraryUnitTest.Math math = new ClassLibraryUnitTest.Math();
            Single a = (math.Saldo + 1);
            Exception result = new Exception();
            Assert.ThrowsException<Exception>(() => math.Transaction("-", a));
        }


    }
}
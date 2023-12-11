namespace MultiLayerUnitTestLogicTests
{
    [TestClass]
    public class MathLogicTests
    {
        [TestMethod]
        public void TestAddition()
        {
            //Arange
            int expectedResult = 10;
            //Act
            MultiLayerUnitTestLogic.MathLogic mathLogic = new MultiLayerUnitTestLogic.MathLogic();
            int result = mathLogic.Addition();
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDifference()
        {
            //Arange
            int expectedResult = 0;
            //Act
            MultiLayerUnitTestLogic.MathLogic mathLogic = new MultiLayerUnitTestLogic.MathLogic();
            int result = mathLogic.Difference();
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            //Arange
            int expectedResult = 25;
            //Act
            MultiLayerUnitTestLogic.MathLogic mathLogic = new MultiLayerUnitTestLogic.MathLogic();
            int result = mathLogic.Multiplication();
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            //Arange
            int expectedResult = 1;
            //Act
            MultiLayerUnitTestLogic.MathLogic mathLogic = new MultiLayerUnitTestLogic.MathLogic();
            int result = mathLogic.Division();
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
using CalculatorBussinessLogic;

namespace CalculatorUnitTestings
{
    [TestClass]
    public class CalculatorLogicTest
    {
        [TestMethod]
        public void Sum_Test()
        {
            //Arrange
            CalculatorLogic calculatorLogic = new CalculatorLogic();
            decimal a = 2;
            decimal b = 2;
            decimal result = 0;
            decimal expectedResult = 4;
            //Act
            result = calculatorLogic.Sum(a, b);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Difference_Test()
        {
            //Arrange
            CalculatorLogic calculatorLogic = new CalculatorLogic();
            decimal a = 2;
            decimal b = 2;
            decimal result = 0;
            decimal expectedResult = 0;
            //Act
            result = calculatorLogic.Difference(a, b);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Multiplication_Test()
        {
            //Arrange
            CalculatorLogic calculatorLogic = new CalculatorLogic();
            decimal a = 2;
            decimal b = 2;
            decimal result = 0;
            decimal expectedResult = 4;
            //Act
            result = calculatorLogic.Multiplication(a, b);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Division_Test()
        {
            //Arrange
            CalculatorLogic calculatorLogic = new CalculatorLogic();
            decimal a = 2;
            decimal b = 2;
            decimal result = 0;
            decimal expectedResult = 1;
            //Act
            result = calculatorLogic.Division(a, b);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

    }
}
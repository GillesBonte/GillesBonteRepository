namespace ExOef3UnitTestingTests
{
    [TestClass]
    public class ConversionTest
    {
        [TestMethod]
        public void TestCToK()
        {
            //Arrange
            ExOef3UnitTesting.Conversion conversion = new ExOef3UnitTesting.Conversion();
            decimal celsius = 19;
            decimal expectedResult = 292.15m;
            decimal? result;
            //Act
            result = conversion.ConvertCelsiusToKelvin(celsius);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestCToF()
        {
            //Arrange
            ExOef3UnitTesting.Conversion conversion = new ExOef3UnitTesting.Conversion();
            decimal celsius = 19;
            decimal expectedResult = 66.2m;
            decimal result;
            //Act
            result = conversion.ConvertCelsiusToFahrenheit(celsius);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestKToC()
        {
            //Arrange
            ExOef3UnitTesting.Conversion conversion = new ExOef3UnitTesting.Conversion();
            decimal celsius = 298;
            decimal expectedResult = 24.85m;
            decimal result;
            //Act
            result = conversion.ConvertKelvinToCelsius(celsius);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestCToKNull()
        {
            //Arrange
            ExOef3UnitTesting.Conversion conversion = new ExOef3UnitTesting.Conversion();
            decimal? celsius = null;
            //Act
            ArgumentNullException result = new ArgumentNullException();
            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => { conversion.ConvertCelsiusToKelvin(celsius); }) ;
        }
    }

}

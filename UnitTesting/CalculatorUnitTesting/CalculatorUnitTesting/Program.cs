using CalculatorBussinessLogic;
namespace CalculatorUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CalculatorLogic clCalculator = new CalculatorLogic();
            int a = 6; int b = 3;

            Console.WriteLine(clCalculator.Sum(a, b));
            Console.WriteLine(clCalculator.Difference(a, b));
            Console.WriteLine(clCalculator.Division(a, b));
            Console.WriteLine(clCalculator.Multiplication(a, b));

            Console.ReadLine();
                }
    }
}
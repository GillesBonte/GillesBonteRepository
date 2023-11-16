namespace CalculatorBussinessLogic
{
    public class CalculatorLogic
    {
       public decimal Sum(decimal a, decimal b)
        { 
        return a + b;
        }

        public decimal Difference(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Division(decimal a, decimal b) 
        {
            return a / b;
        }  

        public decimal Multiplication(decimal a, decimal b) 
        {
            return a * b;
        }
    }

}
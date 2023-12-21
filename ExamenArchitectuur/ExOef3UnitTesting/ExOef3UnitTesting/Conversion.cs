namespace ExOef3UnitTesting
{
    public class Conversion
    {
        public decimal? ConvertCelsiusToKelvin(decimal? celsius)
        {
            if (celsius == null)
            {
                throw new ArgumentNullException("null");
            }   
            return celsius + 273.15m;
        }
        public decimal ConvertCelsiusToFahrenheit(decimal celsius) 
        {
            return ((celsius * 1.8m) + 32);
        }
        public decimal ConvertKelvinToCelsius(decimal kelvin)
        {
            return (kelvin - 273.15m);
        }
        public decimal ConvertFahrenheitToCelsius(decimal fahrenheit) 
        {
            return (fahrenheit - 32) / 1.8m;
        }

    }
}

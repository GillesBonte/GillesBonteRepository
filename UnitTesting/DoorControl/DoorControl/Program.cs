using DoorControlLogic;
namespace DoorControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intResult;
            Validation validation = new Validation();
            try
            {
                intResult = validation.GetStatus("B69G", 54);
            }
            catch (ArgumentException)
            {

                intResult = 0;
            }

            Console.WriteLine(intResult);
            Console.ReadLine();
        }

        static void LoadMenu()
        {
            Console.WriteLine("1) Start Toegangsvraag");
            Console.WriteLine("2) Afsluiten");
        }

    }

}
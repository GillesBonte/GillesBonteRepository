using DoorControlLogic;
namespace DoorControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Validation validation = new Validation();
            int intResult = validation.GetStatus("1234", 0);
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
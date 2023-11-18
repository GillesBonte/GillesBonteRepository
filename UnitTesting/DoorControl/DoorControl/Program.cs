namespace DoorControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoadMenu();
            string result = Console.ReadKey().ToString();
        }

        static void LoadMenu()
        {
            Console.WriteLine("1) Start Toegangsvraag");
            Console.WriteLine("2) Afsluiten");
        }

    }

}
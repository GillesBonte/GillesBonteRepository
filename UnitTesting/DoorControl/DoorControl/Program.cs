using DoorControlLogic;
using System.Security.Cryptography;

namespace DoorControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoadMenu();
        }
        static void LoadMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Start Toegangsvraag");
            Console.WriteLine("2) Afsluiten");

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == 49)
            {
                ExecuteProgram();
            }

            if (key.KeyChar == 50)
            {
                Console.Clear();
                Environment.Exit(0);
            }

        }
        static void ExecuteProgram()
        {
            Console.Clear();
            Console.Write("Enter TokenID: ");
            string tokenId = Console.ReadLine();
            Console.Write("Enter Doornumber: ");
            int doorNumber = int.Parse(Console.ReadLine());

            int intResult;
            Validation validation = new Validation();
            try
            {
                intResult = validation.GetStatus(tokenId, doorNumber);
            }
            catch (ArgumentException)
            {

                intResult = 0;
            }

            Console.WriteLine(intResult);
            Console.ReadLine();
            LoadMenu();
        }
    }
}



    ///!
    ///Models -> nieuwe project
    ///Logic -> nieuw project
    ///Repo -> nieuw project
    ///view -> nieuw project 
    ///
    ///BL opsplitsen in Repo - Model - Logic
    ///!
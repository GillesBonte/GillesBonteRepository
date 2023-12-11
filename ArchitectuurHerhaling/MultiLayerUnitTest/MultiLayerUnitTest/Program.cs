using System.Security.Cryptography;
using MultiLayerUnitTestLogic;

MathLogic mathLogic = new MathLogic();
bool flagEnd = false;

do
{
    ToonMenu();
    ConsoleKeyInfo keyInfo = Console.ReadKey();

    switch (keyInfo.Key) // need the .key of the keyinfo
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            Console.Clear();
            Console.WriteLine(mathLogic.Addition());
            ;
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            Console.Clear();
            Console.WriteLine(mathLogic.Difference());
            break;
        case ConsoleKey.D3:
        case ConsoleKey.NumPad3:
            Console.Clear();
            Console.WriteLine(mathLogic.Multiplication());
            break;
        case ConsoleKey.D4:
        case ConsoleKey.NumPad4:
            Console.Clear();
            Console.WriteLine(mathLogic.Division());
            break;
        case ConsoleKey.D5:
        case ConsoleKey.NumPad5:
            flagEnd = true;
            break;

    }
}
while (flagEnd == false);

static void ToonMenu()
{
    Console.WriteLine("Menu: 5 & 5");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Difference");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");
}
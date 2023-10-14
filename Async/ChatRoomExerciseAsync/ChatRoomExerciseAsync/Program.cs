using System.Runtime.CompilerServices;

namespace ChatRoomExerciseAsync
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            List<string> rooms = new List<string>();
            Dictionary<string, List<string>> roomMessages = new Dictionary<string, List<string>>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Create a room");
                Console.WriteLine("2. Join a room");
                Console.WriteLine("3. Quit");
                Console.WriteLine("Enter your choice: ");
                string strUserInput = Console.ReadLine();

                switch (strUserInput)
                {
                    case "1":
                        Console.WriteLine("Enter RoomName: ");
                        string strRoomName = Console.ReadLine();
                        rooms.Add(strRoomName);
                        roomMessages[strRoomName] = new List<string>();
                        Console.WriteLine($"Room {strRoomName} created.");
                        break;
                    case "2":
                        Console.WriteLine("Enter RoomName: ");
                        string strRoomToJoin = Console.ReadLine();

                        if (rooms.Contains(strRoomToJoin))
                        {
                            Console.WriteLine($"Joined room {strRoomToJoin}.");
                            await HandleRoomAsync(strRoomToJoin, roomMessages);
                        }
                        else
                        {
                            Console.WriteLine("Room not found.");
                        }
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }

        }

        static async Task HandleRoomAsync(string strRoom, Dictionary<string, List<string>> roomMessages)
        {
            while (true)
            {
                Console.WriteLine($" --- Room: {strRoom} ---");
                Console.WriteLine("1. Send message");
                Console.WriteLine("2. Leave room");
                Console.WriteLine("Enter your choice: ");
                string strUserInput = Console.ReadLine();

                switch (strUserInput)
                {
                    case "1":
                        Console.WriteLine("Enter message: ");
                        string strMessage = Console.ReadLine();
                        roomMessages[strRoom].Add(strMessage);
                        Console.WriteLine("Sent");
                        await ShowMessagesAsync(strRoom, roomMessages);
                        break;
                    case "2":

                        return;
                }

            }

        }

        static async Task ShowMessagesAsync(string Room, Dictionary<string, List<string>> roomMessages)
        {
            Console.Clear();

            if (roomMessages.ContainsKey(Room))
            {
                foreach (string strMessage in roomMessages[Room])
                {
                    Console.WriteLine(strMessage);
                }

            }

            Console.ReadLine();

        }


    }

}
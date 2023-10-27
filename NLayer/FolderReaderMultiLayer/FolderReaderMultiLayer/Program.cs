using ProcessingLibraryMultiLayer;

namespace FolderReaderMultiLayer
{
    public class Program
    {


        public static void Main(string[] args)
        {
            string folderToRead = AppDomain.CurrentDomain.BaseDirectory + "TestFolder";
            bool flagEnd = false;
            
            do
            {
                ToonMenu();
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key) 
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        string[] bestanden = new ProcessingLibraryMultiLayer.ProcessMultiLayerClass().ToonBestanden(folderToRead);
                        foreach (string bestand in bestanden)
                        {
                            Console.WriteLine(bestand);
                        }
                        break;
                    //case 2:

                    //    break;
                    //case 3:
                    //    break;

                }

            } while (flagEnd);
        }

        static void ToonMenu()
        {
            Console.WriteLine("Maak uw keuze:");
            Console.WriteLine("1. Toon bestanden in map");
            Console.WriteLine("2. Toon inhoud eerste bestand");
            Console.WriteLine("3. Einde");
        }
    }
}
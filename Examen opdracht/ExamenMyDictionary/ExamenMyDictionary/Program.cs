namespace ExamenMyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FirstTest();
            //SecondTest();
            //ThirdTest();
            Console.ReadLine();
        }

        private static void ThirdTest()
        {
            MyDictionary<int, int> myDic = new MyDictionary<int, int>();

            //subscribe to events
            myDic.DoubleKeyEvent += MyDictionary_DoubleKeyEvent;
            myDic.KeyCountEvent += MyDictionary_KeyCountEvent;

            myDic.Remove(5);
            //unsub from events
            myDic.DoubleKeyEvent -= MyDictionary_DoubleKeyEvent;
            myDic.KeyCountEvent -= MyDictionary_KeyCountEvent;
        }

        private static void SecondTest()
        {
            MyDictionary<DateTime, string> dateMyDictionary = new MyDictionary<DateTime, string>();

            dateMyDictionary.DoubleKeyEvent += MyDictionary_DoubleKeyEvent;
            dateMyDictionary.KeyCountEvent += MyDictionary_KeyCountEvent;

            dateMyDictionary.Add(new DateTime(2010, 1, 1), "dit");
            dateMyDictionary.Add(new DateTime(2011, 3, 1), "is");
            dateMyDictionary.Add(new DateTime(2013, 4, 1), "een");
            dateMyDictionary.Add(new DateTime(2011, 1, 1), "test");
            dateMyDictionary.Add(new DateTime(2012, 1, 1), "!!!");

            dateMyDictionary.Values();

            Console.ReadKey();

            dateMyDictionary.Add(new DateTime(2015, 5, 5), "HAHAHA");

            dateMyDictionary.Values();

            Console.ReadKey();
            dateMyDictionary.DoubleKeyEvent -= MyDictionary_DoubleKeyEvent;
            dateMyDictionary.KeyCountEvent -= MyDictionary_KeyCountEvent;
        }

        private static void FirstTest()
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            myDictionary.DoubleKeyEvent += MyDictionary_DoubleKeyEvent;
            myDictionary.KeyCountEvent += MyDictionary_KeyCountEvent;

            List<int> list = new List<int>();

            myDictionary.Add("string1", 1);
            myDictionary.Add("string2", 2);
            myDictionary.Add("string3", 3);
            myDictionary.Add("string4", 4);
            myDictionary.Add("string4", 5);
            myDictionary.Add("string5", 6);
            myDictionary.Add("string6", 7);
            myDictionary.Add("string7", 8);
           
            myDictionary.Values();
           
            Console.ReadLine();
           
            myDictionary.Add("QBLABJKALBJA", 9);
            
            Console.ReadKey();

            myDictionary.Remove("string3");

            myDictionary.Values();

            Console.ReadKey();

            //unsub from the events after all has been tested
            myDictionary.DoubleKeyEvent -= MyDictionary_DoubleKeyEvent;
            myDictionary.KeyCountEvent -= MyDictionary_KeyCountEvent;
        }

        private static void MyDictionary_KeyCountEvent(object? sender, EventArgs e)
        {
            Console.WriteLine($"Keycount: {e}");
        }

        private static void MyDictionary_DoubleKeyEvent(object o, DoubleKeyEventArgs e)
        {
            Console.WriteLine("Double Key Found");
        }
    }
}
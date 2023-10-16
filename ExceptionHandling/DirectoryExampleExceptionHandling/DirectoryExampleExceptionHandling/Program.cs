namespace DirectoryExampleExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the file-property "Copy to Output Directory" needs to be enabled (copy always)
            var numbersList = File.ReadAllLines(Directory.GetCurrentDirectory() + "/Info.txt");
            List<int> numbers = new List<int>();

            try
            {
                foreach (var item in numbersList)
                {
                    numbers.Add(int.Parse(item));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooops, something went wrong.");
            }
            finally
            {
                foreach(var item in numbers)
                {
                    Console.WriteLine(item);
                }
            }




        }
    }
}
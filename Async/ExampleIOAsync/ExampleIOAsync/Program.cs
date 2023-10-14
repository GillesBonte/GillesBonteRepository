namespace ExampleIOAsync
{
    internal class Program
    {       
        static async Task Main()
        {
            string result = await DownloadWebPageAsync("https://example.com");
            Console.WriteLine($"Web Page Content: {result.Length} characters");
        }

        static async Task<string> DownloadWebPageAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }
    }
}
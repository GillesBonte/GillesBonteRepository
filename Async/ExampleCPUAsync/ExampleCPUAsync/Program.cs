namespace ExampleCPUAsync
{
    public class Program
    {
        static async Task Main()
        {
            int result = await ComputeFactorialAsync(15);
            Console.WriteLine($"Factorial: {result}");
        }

        static async Task<int> ComputeFactorialAsync(int n)
        {
            return await Task.Run(() => Factorial(n));
        }

        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}
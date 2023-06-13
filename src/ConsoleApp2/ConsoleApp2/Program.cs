// See https://aka.ms/new-console-template for more information
public class Program
{
    static async Task Main(string[] args)
    {
        int[] number = new int[] { 1, 2, 3, 4, 5, 6,7,8,9,10 };
        
        Console.WriteLine("Performing parallel calculations ...");

        Parallel.For(0, number.Length, i =>
        {
            int result = Calculate(number[i]);
            Console.WriteLine($"Result: {result}");
        });

        Console.WriteLine("All calculations completed");
    }

    private static int Calculate(int number)
    {
        Task.Delay(1000).Wait();
        return number * 2;
    }
}

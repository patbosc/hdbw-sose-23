// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Program
{
    class Counter
    {
        public event EventHandler ThresholdReached;

        private int count;
        private int threshold = 5;

        public void Increment()
        {
            count++;
            if (count >= threshold)
            {
                OnThresholdReached(EventArgs.Empty);
            }
        }

        private void OnThresholdReached(EventArgs e)
        {
            ThresholdReached?.Invoke(this, e);
        }
    }

    public static void Main(string[] args)
    {
        Counter c = new ();
        c.ThresholdReached += c_ThresholdReached;

        for (int i = 0; i < 10; i++)
        {
            c.Increment();
        }
    }

    private static void c_ThresholdReached(object? sender, EventArgs e)
    {
        Console.WriteLine("The threshold was reached.");
    }
}
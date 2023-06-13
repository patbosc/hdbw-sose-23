// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task task1 = DoTask("Task 1");
        Task task2 = DoTask("Task 2");
        Task task3 = DoTask("Task 3");

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("All tasks completed.");
        Console.ReadLine();
    }

    static async Task DoTask(string taskName)
    {
        // Perform the task logic here
        Console.WriteLine($"Task {taskName} started.");
        // Simulate some asynchronous work
        await Task.Delay(2000);
        Console.WriteLine($"Task {taskName} completed.");
    }
}
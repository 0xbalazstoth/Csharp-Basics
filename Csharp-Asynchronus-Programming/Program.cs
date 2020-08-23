using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; //Required for asynchronus programming

namespace Csharp_Asynchronus_Programming
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await CountingToFive();
            await CountingFromFiveToTen();
            WaitingUntilProcessDoneWithSynchronus();
            await WaitingUntilProcessDoneWithAsyncronus();

            Console.ReadKey();
        }

        private static async Task WaitingUntilProcessDoneWithAsyncronus()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i < 6 + 1; i++)
                {
                    Console.WriteLine($"Task id: {Task.CurrentId}, Values: {i}");
                }
            }).ContinueWith(c => Console.WriteLine(Task.CompletedTask.IsCompleted ? "Done" : "Not done!"));
        }

        private static void WaitingUntilProcessDoneWithSynchronus()
        {
            List<Task> Tasks = new List<Task>();
            Tasks.Add(Task.Run(() =>
            {
                for (int i = 1; i < 100 + 1; i++)
                {
                    Console.WriteLine($"Task id: {Task.CurrentId}, Values: {i}");
                }
            }));
            Task.WaitAll(Tasks.ToArray());
            Console.WriteLine("I think I've finished.");
        }

        static async Task CountingToFive()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i < 5 + 1; i++)
                {
                    Console.WriteLine($"Task id: {Task.CurrentId}, Values: {i}");
                }
            });
        }

        static async Task CountingFromFiveToTen()
        {
            await Task.Run(() =>
            {
                for (int i = 5; i < 10 + 1; i++)
                {
                    Console.WriteLine($"Task id: {Task.CurrentId}, Values: {i}"); ;
                }
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        List<Task<long>> tasks = new List<Task<long>>();

        for (int ctr = 1; ctr <= 10; ctr++)
        {
            int delayInterval = 18 * ctr;
            tasks.Add(Task.Run(async () =>
            {
                long total = 0;
                await Task.Delay(delayInterval);
                var rnd = new Random();
                for (int n = 1; n <= 1000; n++)
                    total += rnd.Next(0, 1000);
                return total;
            }));
        }

        var continuation = Task.WhenAll(tasks);

        try
        {
            continuation.Wait();
        }
        catch (AggregateException)
        {
        }

        if (continuation.Status == TaskStatus.RanToCompletion)
        {
            long grandTotal = 0;
            foreach (var result in continuation.Result)
            {
                grandTotal += result;
                Console.WriteLine("Mean: {0:N2}, n = 1,000", result / 1000.0);
            }
            Console.WriteLine("\nMean of Means: {0:N2}, n = 10,000", grandTotal / 10_000.0);
        }
        else
        {
            foreach (var t in tasks)
            {
                Console.WriteLine("Task {0}: {1}", t.Id, t.Status);
            }
        }
    }
}

using System;
using System.IO;
using System.Threading;

class Program
{
    private static Mutex mutex = new Mutex();

    static void Main()
    {
        File.Delete("test.txt"); 
        File.("test.txt");
        Thread thread1 = new Thread(() => WriteToFile("Thread 1"));
        Thread thread2 = new Thread(() => WriteToFile("Thread 2"));

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Both threads completed");
    }
    
    static void WriteToFile(string threadName)
    {
        mutex.WaitOne();
        try
        {

            File.AppendAllText("test.txt", $"{threadName} writing...\n");
            Program.Loading(); // Simulate work
            File.AppendAllText("test.txt", $"{threadName} finished writing.\n");
        }
        finally
        {
            mutex.ReleaseMutex();
        }
    }
    static void Loading()
    {
        for (int i = 0; i < 4 * 3; i++)
        {
            Char[] loadingSymbols = { '\\', '|', '/', '-' };
    
            Console.WriteLine("Loading: " + loadingSymbols[i % loadingSymbols.Length]);
            
            Thread.Sleep(1000);
        }
    }
}


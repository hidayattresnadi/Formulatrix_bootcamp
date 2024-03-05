// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using System.Diagnostics;

class Program
{
    static void Main()
    {
        int limit = 20000;
        string a = "a";
        Stopwatch stopwatch = new();
        stopwatch.Start();
        for (int i = 0; i < limit; i++)
        {
            a += "b";
            a += "c";
            a += "d";
            // Console.WriteLine(a);
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
        // Console.ReadLine();
    }
}


// Console.

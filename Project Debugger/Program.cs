// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

class Program
{
    static void Main()
    {
        ConsoleTraceListener consoleTraceListener = new();
        TextWriterTraceListener textWriterTraceListener = new("trace.log");
        Trace.Listeners.Add(consoleTraceListener);
        Trace.Listeners.Add(textWriterTraceListener);
        Trace.WriteLine("start program");
        // Trace.AutoFlush=true;
        
        Human human = new();
        var result = human.Counting(200);
        Console.WriteLine(result["OddNumber"]);
        Console.WriteLine(result["EvenNumber"]);
        Trace.Flush();

        // while (true)
        // {
        //     human.ChangingConsole();
        //     // Thread.Sleep(5000);
        //     Task.Delay(5000);
        // }
    }
}

class Human
{

    public void ChangingConsole()
    {
        Console.WriteLine("akwakwk");
    }
    public Dictionary<string, int> Counting(int numbers)
    {
        int counterEven = 0;
        int counterOdd = 0;
        for (int i = 1; i < numbers; i++)
        {
            if (i % 2 == 0)
            {
                counterEven++;
            }
            else
            {
                counterOdd++;
            }
        }
        Dictionary<string, int> dict = new();
        dict.Add("OddNumber", counterOdd);
        dict.Add("EvenNumber", counterEven);
        return dict;
    }
}

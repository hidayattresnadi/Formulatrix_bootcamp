// See https://aka.ms/new-console-template for more information
using TheAnswer;

class Program
{
    static void Main()
    {
        Result hasil = new();
        Dictionary<int,string> dict = new();
        dict.Add(3,"foo");
        dict.Add(5,"bar");
        dict.Add(7,"buzz");

        string result = hasil.MakeSentence(21,dict);
        Console.WriteLine(result);
    }
}

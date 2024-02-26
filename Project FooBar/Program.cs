// See https://aka.ms/new-console-template for more information
using TheAnswer;

class Program
{
    static void Main()
    {
        Result hasil = new();
        Dictionary<int,string> dayat = hasil.InputUser(15);
        string dayat1 = string.Join(",",dayat.Values);
        // string dayat1 = string.Join(",",dayat);
        Console.WriteLine(dayat1);
    }
}

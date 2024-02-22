// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Human human = new();
        human.Balance = 1000;
        Console.WriteLine(human.Tax);
        human.Method();
    }
}

// merapikan code : 1. ctrl + A 2. ctrl + k 3. ctrl + F

// See https://aka.ms/new-console-template for more information
using Calculate;
class Program {
    static void Main()
{
	Calculator calc = new();
	int result = (int) calc.Add(3,2);
    string results = (string)calc.Add("3","2");

    Calculator balance = new();
    Console.WriteLine(balance.GetBalance(2000));
    Console.WriteLine(Calculator.GetCount());

    int addFlexible = Calculator.AdditionFlexible(2,3,4);
    Console.WriteLine($"hasil dari penjumlahan parameter flexible adalah : {addFlexible}");

    Console.WriteLine(result);
    Console.WriteLine(results);
}
}

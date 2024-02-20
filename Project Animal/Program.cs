// See https://aka.ms/new-console-template for more information
using Zoo;

class Program {
    static void Main(){
        Fish nemo = new("white","male");
        nemo.fin=4;
        Console.WriteLine(nemo.fin);
        Console.WriteLine(nemo.colour);
        Console.WriteLine(nemo.gender);

        Snake phyton = new("phyton","female");
        phyton.length=12;
        Console.WriteLine(phyton.colour);
        Console.WriteLine(phyton.gender);
        Console.WriteLine(phyton.length);

    }
}

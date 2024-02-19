// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(){
        Cat cinamon = new Cat();
        // cinamon.colour="gray";
        cinamon.gender="female";
        cinamon.length=3;
        cinamon.isAlive=true;

        Console.WriteLine(cinamon.length);
        cinamon.Meow();
        // cinamon.inherit();
        Console.WriteLine(cinamon.colour);

        Car honda = new Car();
        honda.name = "red";
        honda.length=18;
        honda.height=2.2f;
        honda.weight=1.2d;
        honda.horn();
        Console.WriteLine(honda.name);
        Console.WriteLine(honda.length);
        Console.WriteLine(honda.height);
        Console.WriteLine(honda.weight);
    }
}
class Cat
{
    public string colour = "blue";

    public string gender ="female";

    public int length;

    public bool isAlive;

    public void Meow(){
        Console.WriteLine("Meow");
    }

    public void Run(){
        Console.WriteLine("Run");
    }

    public void inherit(){
        this.colour="blue";
    }
}


class Car
{
    public string name;
    public int length;

    public float height;

    public double weight;

    public void horn(){
        Console.WriteLine("telolet");
    }
}
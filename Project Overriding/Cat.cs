namespace OverRiding;

public class Cat : Animal{
    public Cat(string gender,string colour,string name) : base (gender,colour,name) {

    }
    public override void Sound()
    {
        Console.WriteLine("Meowww");
    }
}
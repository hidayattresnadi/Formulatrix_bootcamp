namespace OverRiding;

public class Dog : Animal {

    public Dog (string gender,string colour,string name) : base (gender,colour,name){

    }

    public override void Sound()
    {
        Console.WriteLine("Bark");
    }

}
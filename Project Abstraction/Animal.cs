abstract class Animal {
    public string gender;
    public string name;
    public abstract void Sound();
}

class Cat : Animal {
    public override void Sound()
    {
        Console.WriteLine("Meow");
    }

}
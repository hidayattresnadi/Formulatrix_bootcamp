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

abstract class Hewan {
    private int height;

    public int Height1 {
        get{
            return height;
        }
        set{
            height=value;
        }
    }
    public abstract void walk();
}

class Kucing : Hewan {
    public override void walk(){
        Console.WriteLine("jalan-jalan");
    }
}
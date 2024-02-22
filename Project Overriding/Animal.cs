namespace OverRiding;
public class Animal {
    public string colour;
    public string gender;

    public string name;


    public Animal(string gender,string colour,string name){
        this.gender=gender;
        this.colour=colour;
        this.name=name;
    }

    public virtual void plus(){
        int a = 2;
        double b = a;

        Console.WriteLine($"{a},{b}");

        double c = Math.Ceiling(3.9);
        int d = (int)c;

        Console.WriteLine($"{c},{d}");

        int e = 9;
        float f = e;

        Console.WriteLine(f);

        float g = 9.1f;
        int h = (int)g;

        // Console.WriteLine(g);
    }


    // virtual, supaya nanti bisa diambil alih sama child, semisal childnya pengen outputnya beda
    // boleh ngikutin parentnya atau bikin sendiri (optional)
    public virtual void Sound(){
        Console.WriteLine("Make sound");
    }
}
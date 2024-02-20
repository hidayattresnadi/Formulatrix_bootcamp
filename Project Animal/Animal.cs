namespace Zoo;

// dikasih syarat supaya kalau mau animal terbentuk, harus diisi gender dan colournya
class Animal {
    public string colour;
    public string gender;

    public Animal(string colour,string gender){
        this.colour=colour;
        this.gender=gender;
    }

    public void walk(){
        Console.WriteLine("I can walk");
    }

    public void breath(){
        Console.WriteLine("I can breath");
    }
    
}
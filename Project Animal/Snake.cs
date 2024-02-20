namespace Zoo;

// class Snake : Animal, artinya inheritance si class snake biar bisa make apa aja yang ada di class Animal

class Snake : Animal {
    public int length;

    public Snake(string colour,string gender) : base (colour,gender){}

    public void ssh(){
        Console.WriteLine("maybe this is how snake sound");
    }
}
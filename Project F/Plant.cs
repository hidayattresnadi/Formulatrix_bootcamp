// Public : semua folder bisa make program itu. internal : yang bisa make cuman yang satu folder aja
// Protected : yang bisa make cuman class itu sendiri dan sub classnya (anak) Private : cuman class itu sendiri aja yang bisa make

class Plant {
    public void Respiration() {
    Console.WriteLine("photosynthesis");
    }

    private void Breath(){
        Console.WriteLine("hmmm");
    }

    internal void hmm(){
        Console.WriteLine("wkwkwkw");
    }

    protected void lol (){
        Console.WriteLine("awkakwakw");
    }
}
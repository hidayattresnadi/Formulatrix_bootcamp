namespace Zoo;

// supaya dapat terisi parentnya, karena kan yang terbentuk awal parent dlu baru child, maka digunakan base
// seperti di bawah ini : jadinya memanggil constructor parent supaya diisi data terlebih dahulu

class Fish : Animal {
    public int fin;

    public Fish (string colour,string gender) : base (colour,gender){

    }

    public void swim(){
        Console.WriteLine("I can swim");
    }

}
public class Human {

    // di bawah disebut property karena ada variable sekaligus methodnya yaitu get dan set
    // pada tingkat akses methodnya, set dibuat lebih strict daripada get. Misal kita ingin set hanya kelas itu saja
    // maka caranya seperti ini :
    public int Salary {get;private set;} 

    public int Tax {get;private set;} = 1000;

    // di bawah ini adalah variable
    private int _balance;

    // untuk yang ini berarti get dan set dapat dilakukan oleh class manapun

    public int Balance {
        get {
            return _balance;
        }
        set  {
            _balance = value*1000;
        }
    }

    // di bawah ini disebut dengan method

    public void Method(){
        Console.WriteLine(_balance);
    }
}
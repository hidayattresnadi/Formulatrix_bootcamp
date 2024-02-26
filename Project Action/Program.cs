// See https://aka.ms/new-console-template for more information
// Func dan Action ini merupakan fungsi bawaan dari Microsoftnya
using System.Security.Cryptography.X509Certificates;

public delegate void MyDelegates(string s); 
class Program {
    static void Main(){
        // cara lama
        Player pemain = new();
        Friend teman = new();
        MyDelegates delegator = pemain.Register;

        teman.myFriend += pemain.oi;

        // cara Action, tetapi action harus void return ga bisa ada return typenya
        Action<string> delegators = pemain.Register;
        delegators += pemain.Greet;

        // kalau mau ada return typenya make func jadi parameter terakhir diisi dengan return typenya
        // int terakhir diisi dengan return type dari function Add

        Func<int, int, int,int> addition = pemain.Buy;

        // di sebelah delegaor ini ada tanda tanya, naah ini tuh maksudnya kaya ternery, jadi semisal null parameternya
        // functionnya ga akan jalan

        delegator?.Invoke("dayat");
        int data = addition.Invoke(20000,10000,2);

        Console.WriteLine(data);

        // Anonymous method, kaya javascript function arrow itu sih cuman dia buat function yang linenya 1 atau 2 aja, simple
        // kalau banyak line yaa musti bikin method baru

        Func<int,int,float> AddFriend = (int a , int b)=> (a+b);
        Action<bool> ConfirmFriend = (bool confirmed) => Console.WriteLine(confirmed);

        float hasil = AddFriend.Invoke(2,5);
        Console.WriteLine(hasil);
        ConfirmFriend.Invoke(true);
    }
}

class Player {

    public void Register(string s){
        Console.WriteLine(s);
    }

    public void Greet(string s){
        Console.WriteLine(s);
    }

    public void oi (){
        Console.WriteLine("hmm");
    }

    public int Buy(int a, int b, int c){

        return a-(b*c);
    }

}

class Friend {
    public event Action myFriend;
}
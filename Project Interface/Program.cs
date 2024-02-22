// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// semisal kita mau set variable tapi set itu kan biasanya lebih strict dari get dan set ga mungkin public
// jadi dari interfacenya get aja, trus d anaknya baru pakein set secara private
public interface Lol {
    // ini juga bisa dikatakan interfacenya read only, karena g ada method setnya
    public int Balance {get;}
}

public class Hmm : Lol {
    public int Balance {get;private set;}    
}

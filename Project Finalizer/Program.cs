// See https://aka.ms/new-console-template for more information
// gc = garbage collection, jadi buat ngebersihin data2 yang sudah tidak terpakai, semisal string kan setiap kita += dia bakal alokasi memori baru terus, makanya buat buang2 memori ini, dipake gc
// gc collect di sini jadi untuk mendapatkan data di setiap generasi penyimpanannya, klo diisi 0 ya nanti berarti si gc collect data2 yang ada di gen 0
// Finalizer ditandai dengan ada simbol ~ di sebelah nama classnya jadi finalizer tuh kaya proses sesuatu sebelum class itu misal ntar dibersihkan datanya
// Finalizer itu jadi kaya permintaan terakhir lah wkkwwk
class Program
{
    static void Main(){
        InstanceCreator();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("Wait for the next order");
    }
    static void InstanceCreator(){
        Child child = new();
    }
}
public class GrandParent
{
    ~GrandParent(){
        Console.WriteLine("GrandParent eliminated");
        // Console.WriteLine(Thread.CurrentThread);
    }
}
public class Parent : GrandParent
{
    public Parent(){
        Console.WriteLine("HMMM");
    }
    ~Parent(){
        Console.WriteLine("Parent eliminated");
    }
}
public class Child : Parent
{
    ~Child(){
        Console.WriteLine("Child eliminated");
    }
}
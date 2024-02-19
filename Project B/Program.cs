
public class Program 
{
    public static void Main (){
        Calculator hasil = new Calculator();
        hasil.Addition(2,3);
        int result = hasil.decrease(4,2);
        Console.WriteLine($"Hasil dari pengurangan ini yaitu {result}");
    }
}

class Calculator {
    public void Addition(int angka1,int angka2){
        Console.WriteLine(angka1+angka2);
    }

    public int decrease(int angka1,int angka2){
        return angka1 -  angka2;

    }
}

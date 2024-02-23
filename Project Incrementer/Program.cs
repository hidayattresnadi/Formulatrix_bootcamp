// Out jadinya declare variablenya di dalam function, jadi variable yang masuk ke function itu ditiadakan
// tetapi nanti variable yang masuk itu akan diassign sesuai output dari function yang telah berjalan

// In jadinya 
class Program {
    static void Main (){
        int a = 2;
        Incrementer(a);
        int c = IncrementIn(a);
        Console.WriteLine($"ini adalah variable c : {c}");
        Console.WriteLine(a);

        Decrease(ref a);
        Console.WriteLine(a);

        Incrementers(out a);
        Console.WriteLine($"incrementers yaitu {a}");

        Car b = new(2);
        IncrementerCar(b);
        Console.WriteLine(b.price);

        string userInput = "123"; 

        int number;
        if (int.TryParse(userInput, out number)) {
            Console.WriteLine($"Parsed successfully! The number is: {number}");
        } else {
            Console.WriteLine("Failed to parse input as an integer.");
        }
    }
    static void Incrementer (int a){
        a++;
    }
    static void IncrementerCar(Car car){
        car.price++;
    }

    static int IncrementIn(in int a){
        // a ++;
        int b = a +2 ;
        return b;

    }

    static void Decrease(ref int a){
        a--;
    }

    static void Incrementers( out int a){
        a =3;
        a +=3;
    }
}

class Car {
    public int price;

    public Car (int price){
        this.price=price;
    }
}

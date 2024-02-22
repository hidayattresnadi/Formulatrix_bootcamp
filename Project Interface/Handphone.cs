public interface IHandphone {
    void Wifi();
    void Bluetooth();

    void Photo();
}

public interface IIphone : IHandphone;

class IPhone11 : IIphone {
    public void Wifi(){
        Console.WriteLine("bisa wifi");
    }

    public void Bluetooth(){
        Console.WriteLine("bisa bluetooth");
    }

    public void Photo(){
        Console.WriteLine("bisa foto");
    }
}

class IPhone12 : IIphone {
    public void Wifi(){
        Console.WriteLine("bisa wifi");
    }

    public void Bluetooth(){
        Console.WriteLine("bisa bluetooth");
    }

    public void Photo(){
        Console.WriteLine("bisa foto");
    }
}
// See https://aka.ms/new-console-template for more information
class Program {
    static void Main (){
        Shop shopA = new(2000);
        Shop shopB = new(3000);

        // overloading operator, jadinya kaya di bawah, kita ga define properti apa yang dijumlahin jadi langsung objeknya jumlahin bisa

        Shop result = shopA + shopB;
        Console.WriteLine(result.GetPrice());
    }
}

class Shop {
    private int price;
    private int quantity;

    private int total;

    public Shop (int price){
        this.price=price;
    }

    public int GetPrice (){
        return price;
    }

    //Operator Overloading +
	// makenya static method
	//return Value => class
	//Parameter
	//symbol : / * + - == % < > ++ -- !=
    // nah penggunannya di sini

    public static Shop operator + (Shop a,Shop b ){
        return new Shop(a.price + b.price);
    }
}

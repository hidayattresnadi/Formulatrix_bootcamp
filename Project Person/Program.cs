// See https://aka.ms/new-console-template for more information
using TShirt;
using Human;
class Program() {
    static void Main () {
        Human.Handphone handphone = new("iPhone",0898989);
        Shoes shoes = new Shoes("adidas",42);
        Person dayat = new Person("Dayat",170,"male",handphone,shoes);
        Console.WriteLine(dayat.handphone.name);
        Console.WriteLine(dayat.shoes.size);
        Console.WriteLine($"hello, my name is {dayat.name}, height is {dayat.height}, my gender is {dayat.gender}");
        Shirt kaos = new Shirt("s","catoon");
    }
}

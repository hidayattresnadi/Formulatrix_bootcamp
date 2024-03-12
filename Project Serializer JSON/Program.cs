// See https://aka.ms/new-console-template for more information
// yang bisa diserializer itu klo dari json, itu hanya property => yang ada get setnya dah harus dibuat public
using System.Text.Json;

public class City {
    public string nation {get;set;}
    public int price {get;set;}

    public string name {get;set;}

    public City (){}

    public City(string _nation,int _price,string _name){
        nation=_nation;
        price=_price;
        name=_name;
    }
}
class Program {
    static void Main (){
        // cara write file json 
        // City city1 = new("Indonesia",25000,"Jakarta");
        // City city2 = new("Singapore",30000,"Singapore");
        // City city3 = new("Japan",50000,"Tokyo");

        // List<City> cities = new List<City> {city1,city2,city3};
        // string json = JsonSerializer.Serialize(cities);
        // using (StreamWriter sw = new("file.json")){
        //     sw.WriteLine(json);
        // }

        // cara read json file
        string result;
        using(StreamReader sr = new("file.json")){
           result = sr.ReadToEnd();
        }
        Console.WriteLine(result);
        City[] cities = JsonSerializer.Deserialize<City[]>(result);
        foreach (var city in cities)
        {
            Console.WriteLine(city.name);
            Console.WriteLine(city.nation);
            Console.WriteLine(city.price);
        }
    }
}
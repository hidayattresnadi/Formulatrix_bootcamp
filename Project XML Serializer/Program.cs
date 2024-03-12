// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
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
class Program 
{
	static void Main() 
	{
        // cara write file xml
		// City city1 = new("Indonesia",25000,"Jakarta");
        // City city2 = new("Singapore",30000,"Singapore");
        // City city3 = new("Japan",50000,"Tokyo");
		// City[] cities = new City[] { city1, city2, city3 };
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(City[]));
		// using(StreamWriter sw = new("file.xml")) 
		// {
		// 	xmlSerializer.Serialize(sw, cities);
		// }
        // cara read file xml
		City[] result;
		using(StreamReader sr = new("file.xml")) 
		{
			result = (City[])xmlSerializer.Deserialize(sr);
		}
		foreach(var city in result) 
		{
			Console.WriteLine(city.price);
			Console.WriteLine(city.name);
		}
	}
}

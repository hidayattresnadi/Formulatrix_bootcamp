﻿using System.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
//DataContract attribute is used to mark the class as serializable
[DataContract]
class Human 
{
	[DataMember]
	private string name;
	[DataMember]
	private int age;
	public Human(string name, int age) 
	{
		this.name = name;
		this.age = age;
	}
	public string GetName() 
	{
		return name;
	}
	public int GetAge()
	{
		return age;
	}
}
class Program 
{
	static void Main() 
	{
		//Serializer
		Human human = new Human("John", 25);
		DataContractJsonSerializer serializer = new(typeof(Human));
		// using(FileStream sw = new("human.json", FileMode.Create))
		// {
		// 	serializer.WriteObject(sw, human);
		// }

		//Deserializer
		Human result;
		using(FileStream sr = new("human.json", FileMode.Open))
		{
			result = (Human)serializer.ReadObject(sr);
		}
		Console.WriteLine(result.GetName());
		Console.WriteLine(result.GetAge());
	}
}
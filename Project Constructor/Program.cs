// See https://aka.ms/new-console-template for more information
using System.Data.Common;

class Program
{
    static void Main (){
        Employee dayat = new Employee("dayat",12);
        dayat.email="test@gmail.com";
        dayat.walk();
        dayat.rest("my home");

        Console.WriteLine($"{dayat.email},{dayat.name},{dayat.id}");

        Employee anonymous = new Employee();
        Console.WriteLine($"id : {anonymous.id}, name : {anonymous.name} , email : {anonymous.email}");

        Employee spongebob = new Employee("spongebob",20,"sponge@gmail.com");
        Console.WriteLine(spongebob.name);
        Console.WriteLine(spongebob.id);
        Console.WriteLine(spongebob.email);
    }
}

class Employee {
    public int id;
    public string name;
    public string email;

    // jika field diisi harus 2 parameter

    public Employee (string name, int id) {
        this.name=name;
        this.id=id;
    }

    // Gimana semisal kondisinya beda2, ada yang ga harus isi sama sekali atau diisi ketiganya, maka :
    // semisal semua kosong dan ingin parameter kosong diisi sesuatu
    public Employee (){
        id = 1;
        name = "guest";
        email="";
    }

    // kondisi harus isi semuanya 

    public Employee (string name,int id, string email){
        this.name=name;
        this.id=id;
        this.email=email;
    }

    public void walk(){
        Console.WriteLine("I am walking");
    }

    public void rest(string place){
        Console.WriteLine($"I am resting at {place} ");
    }
}

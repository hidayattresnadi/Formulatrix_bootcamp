﻿// See https://aka.ms/new-console-template for more information
class Program {
    static void Main(){
        Cat kitten = new();
        kitten.Sound();

        Kucing dayat = new();
        dayat.Height1=12;
        Console.WriteLine(dayat.Height1);
        Console.WriteLine("akwoakwoak");

        MonopolyGameController monopoly = new(20);
        monopoly.AddCard(new BirthdayCard(1,"birhtday","yellow"));
        monopoly.AddCard(new ElectricPaid(2,"electric","green"));

        Console.WriteLine(monopoly.GetCards());
    }
}

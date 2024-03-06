// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Program {
    static void Main(){
        #if DEBUG
        System.Console.WriteLine("Debug");
        #endif
        #if RELEASE
        System.Console.WriteLine("RELEASE");
        #endif
    }
}

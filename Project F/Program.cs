// See https://aka.ms/new-console-template for more information
using System.Text;
class Program {
    static void Main (){
        Plant apple = new Plant();

        apple.Respiration();
        // apple.Breath();

        Apple apple1 = new Apple();

        apple1.Respiration();
        apple1.hmm();
        apple1.someMethod();
        // apple1.Breath();
        using (FileStream fs = File.OpenRead(@"../Project FileStream/test1.txt"))
            {
                byte[] myBytes = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;
                while ((readLen = fs.Read(myBytes, 0, myBytes.Length)) > 0)
                {
                    Console.WriteLine(temp.GetString(myBytes, 0, readLen));
                    Console.WriteLine("Mantabs");
                }
            }

    }
}

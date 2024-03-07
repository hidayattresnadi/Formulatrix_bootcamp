// See https://aka.ms/new-console-template for more information
// thread ini semisal mau nangkep errornya, maka di tiap thread make try catchnya
﻿class Program {
    static void Main() {
        // try
        // {
        string resultPrinter6;

        //Thread is foreground by default
        Console.WriteLine("Program started");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        Thread thread1 = new Thread(Printer); // Printer1
        Thread thread2 = new Thread(Printer2); // Printer2
        Thread thread3 = new Thread(Printer3); // Printer3
        Thread thread4 = new Thread(Printer4); // Printer4
        Thread thread5 = new Thread(()=>Console.WriteLine("Printer 5")); // Printer1
        Thread thread6 = new Thread(()=>Console.WriteLine("Printer 6")); // Printer2
        Thread thread7 = new Thread(()=>Console.WriteLine("Printer 7")); // Printer3
        Thread thread8 = new Thread(()=>Console.WriteLine("Printer 8")); // Printer4
        Thread thread9 = new Thread(()=>Console.WriteLine("Printer 9")); // Printer1
        Thread thread10 = new Thread(()=>Console.WriteLine("Printer 10")); // Printer2
        Thread thread11 = new Thread(()=>Console.WriteLine("Printer 11")); // Printer3
        Thread thread12 = new Thread(()=>Console.WriteLine("Printer 12")); // Printer4
        Thread thread13 = new Thread(()=>Console.WriteLine("Printer 13")); // Printer1
        Thread thread14 = new Thread(()=>Console.WriteLine("Printer 14")); // Printer2
        Thread thread15 = new Thread(()=>Console.WriteLine("Printer 15")); // Printer3
        Thread thread16 = new Thread(()=>Console.WriteLine("Printer 16")); // Printer4
        Thread thread17 = new Thread(()=>{
            resultPrinter6=Printer6("lol");
        }); // Printer4
        Thread thread18 = new Thread(()=>{
            try
            {
                ExceptionMaker();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        });

        // thread1.IsBackground=true;

     
        thread1.Start();
        thread1.Priority=ThreadPriority.Highest;
        // Thread.CurrentThread.Abort();
        thread2.Start();
        thread3.Start();
        thread4.Start();
        thread5.Start();
        thread6.Start();
        thread7.Start();
        thread8.Start();
        thread9.Start();
        thread10.Start();
        thread11.Start();
        thread12.Start();
        thread13.Start();
        thread14.Start();
        thread15.Start();
        thread16.Start();
        thread17.Start();
        thread18.Start();
        // thread1.Abort(); ini forbidden soalnya bisa langsung ngend process threadnya, padahal thread lagi sedang allocate memori
        // // Wait for the threads to finish
        // thread1.Join(); ini supaya main thread menunggu proses dari thread1, baru programnya jalan lanjut
        // thread2.Join();
        Console.WriteLine("Program finished");
        
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }
    }

    static void ExceptionMaker(){
        throw new Exception("Error from exception");
    }
    static string Printer6(string input){
        input = "wkwkw";
        Console.WriteLine("llololooll");
        return input;
    }
    static void Printer() {
        Console.WriteLine("Printer 1");
        // string a = "12a";
        // int b = int.Parse(a);
        // Console.WriteLine(b);
        for(int i = 0; i < 100; i++) {
            Console.Write("+");
            Thread.Sleep(500); // ???
        }
    }
    static void Printer2() {
        Console.WriteLine("Printer2");
        // for(int i = 0; i < 100; i++) {
        //     Console.Write("-");
        // }
    }
    static void Printer3() {
        Console.WriteLine("Printer3");
        // for(int i = 0; i < 100; i++) {
        //     Console.Write("/");
        // }
    }
    static void Printer4() {
        Console.WriteLine("Printer4");
        // for(int i = 0; i < 100; i++) {
        //     Console.Write("?");
        // }
    }
}

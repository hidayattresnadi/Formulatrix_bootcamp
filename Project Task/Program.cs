// See https://aka.ms/new-console-template for more information
// di task untuk handling exception atau error, yaa cukup bkin try catch di main, trus ya udah di tiap task ga perlu dipakein try catch
class Program
{
    static void Main()
    {
        try
        {
            // await task.whenall()
            // trus di main dikasih static async
            // Task task3 = new(() => ExceptionMaker());
            // task3.Start();
            // task3.Wait();
            // Console.WriteLine(task3.IsFaulted);
            // klo task disimpen di variable trus bawahnya baru start berarti task yang dibentuk ga langsung keeksekusi, tar  buat eksekusi
        // trigger pake start
        Task task1 = new(() => Console.WriteLine("nyoba task"));
        task1.Start();
        // task1.Wait();
        // task run berarti habis nulis kodenya, langsung eksekusi kode
        Task.Run(() => Console.WriteLine("nyobain 2 task"));
        // Task.Delay(1000);

        Task task5 = Task.Run(()=>{
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        });
        // status eksekusi code di bawah, jadi cancel yaa dicancel, complete selesai, faulted itu kalau ada hasil error
        Task.WaitAll(task5);
        Console.WriteLine(task5.IsCanceled);
        Console.WriteLine(task5.IsCompleted);
        Console.WriteLine(task5.IsFaulted);
        }
        catch (AggregateException e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
     static void ExceptionMaker(){
        throw new Exception("Error from exception");
    }


}


// See https://aka.ms/new-console-template for more information
// task itu jadi ibaratnya memakai thread yang sudah disediakan sama komputernya. Semisal butuh mobil, yaa tinggal ke rental. Ini dari banyaknya core di komputer
// kalau thread itu, dia alokasiin memori buat bikin si threadnya, jadi semisal butuh mobil, kita beli mobil buat masing2.
// kalau async await, sebenrnya sama seperti task, tapi ketika ada proses belum selesai dan menunggu, dia kembaliin mobilnya ke rental, 
// trus nyuruh cpu buat ngingetin, tar klo dah selesai, minjem lagi mobil rentalan
// semisal kita panggil function yang menggunakan async await, maka function yang manggil tersebut juga harus dijadiin async await, kalau nggak dia error karena yang ada await
// minta make await
// bisa aja ga make await, tapi jadinya nanti function yang dipanggil itu async, yaa dia ga akan selesai prosesnya karena kan kita manggil pas dia masih proses, ga ditungguin
// DeadLock: 1 task menunggu 1 task tapi task yang ditunggu juga nungguin task 1 nya. Race Condition : 1 task itu pa balap2 sama 1 task yang lain, semisal d perempatan, ga ada yang mau ngalah samsek
using System.Diagnostics;

class Program {
        static async Task Main() {
        // for(int i = 0;i< 100;i++) {
        //     ThreadExecution();
        //     TaskExecution();
        //     await TaskAsyncAwait();
        // }
        Stopwatch stopwatch = new();
        
        stopwatch.Start();
        ThreadExecution();
        stopwatch.Stop();
        Console.WriteLine("Thread : " + stopwatch.ElapsedTicks);

        stopwatch.Reset();
        stopwatch.Start();
        TaskExecution();
        stopwatch.Stop();
        Console.WriteLine("TASK : " + stopwatch.ElapsedTicks);

        stopwatch.Reset();
        stopwatch.Start();
        await TaskAsyncAwait();
        stopwatch.Stop();
        Console.WriteLine("Async : " + stopwatch.ElapsedTicks);

        // await CallingFunctionAgain();

        // stopwatch.Reset();
        // stopwatch.Start();
        // await CallingFunction();
        // stopwatch.Stop();
        // Console.WriteLine("Async lala : " + stopwatch.ElapsedTicks);

    }
    static void ThreadExecution() {
        Thread[] threads = new Thread[100];
        for(int i = 0; i < threads.Length; i++) {
            threads[i] = new Thread(() => Execution());
            threads[i].Start();
        }
        foreach(var i in threads) {
            i.Join();
        }
    }
    static void TaskExecution() {
        Task[] allTasks = new Task[100];
        for(int i = 0; i < allTasks.Length; i++) {
            allTasks[i] = new Task(() => Execution2());
            allTasks[i].Start();
        }
        Task.WaitAll(allTasks);
    }
    static async Task TaskAsyncAwait() {
        Task[] allTasks = new Task[100];
        for(int i = 0; i < allTasks.Length; i++) {
            allTasks[i] = new Task(() => Execution3());
            allTasks[i].Start();
        }
        // when all tuh berarti ketika semua tasknya selesai
        await Task.WhenAll(allTasks);
    }
    static void Execution() {
        int iteration = 10;
        for(int i = 0; i<iteration;i++) {
            Console.Write("+");
        }
    }
    static void Execution2() {
        int iteration = 10;
        for(int i = 0; i<iteration;i++) {
            Console.Write("-");
        }
    }
    static void Execution3() {
        int iteration = 10;
        for(int i = 0; i<iteration;i++) {
            Console.Write("/");
        }
    }

    static async Task CallingFunction(){
        await TaskAsyncAwait();
        TaskExecution();
        Console.WriteLine("wkwkw");
    }
    static async Task<string> FetchingAPI(){
        string result;
        using ( HttpClient httpClient = new()){
          HttpResponseMessage response = await httpClient.GetAsync("https://catfact.ninja/fact");
          result = await response.Content.ReadAsStringAsync();
        }
        Console.WriteLine(result);
        return result;
    }
    static async Task CallingFunctionAgain(){
        await FetchingAPI();
        // TaskExecution();
    }
}
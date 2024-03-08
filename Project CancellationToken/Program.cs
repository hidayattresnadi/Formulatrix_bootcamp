﻿class Program {
    static async Task Main() {
        Console.WriteLine("Main method started");
        
        // cara membuat cancellationtoken. Disisipkan ke metode yang memang difungsikan untuk menghentikan suatu proses.
        CancellationTokenSource cts = new();
        // cara generate tokennya
        // disisipkan ke methode yang ingin dihentikan prosesnya
        CancellationToken token = cts.Token;

        // CancellationTokenSource cts = new CancellationTokenSource();
        // CancellationToken token = cts.Token;

        Task task3 = Task.Run(()=>FetchingAPI(token));

        // Task task1 = Task.Run(() => DoPrintJob(token));
        // kalau di task.run d bawah ini make await, tar programnya ga selesai2, soalnya nunggu RefreshPage dieksekusi
        // kalau whenAny dipake maka ketika kita panggil function cancellation token, dia bakal anggap berhasil si programnya. Padahal kan harusnya masuk exception
        // Task task2 = Task.Run(() => RefreshPage(cts));
        Task.Run(() => RefreshPage(cts));
        try
        {
            // await Task.WhenAny(task3,task2);
            await task3;
        } catch(TaskCanceledException) {
            // Console.WriteLine("Print Job Cancelled");
            Console.WriteLine("fetching API Cancelled");
        }
        Console.WriteLine("Main method completed");
    }
    static async Task<string> FetchingAPI(CancellationToken token){
        string result;
        using ( HttpClient httpClient = new()){
          HttpResponseMessage response = await httpClient.GetAsync("https://catfact.ninja/fact");
          await Task.Delay(1000 , token);
          result = await response.Content.ReadAsStringAsync();
        }
        Console.WriteLine(result);
        return result;
    }

    static void RefreshPage(CancellationTokenSource cts){
        if(Console.ReadKey().KeyChar=='r'){
            cts.Cancel();
        }
    }
    static async Task DoPrintJob(CancellationToken token) {
     // Print 1 - 100%
        for(int i = 0; i < 100; i++) {
            Console.WriteLine(i + "%");
            await Task.Delay(100 , token);
            // if(token.IsCancellationRequested) {
            //     Console.WriteLine("Print Job Cancelled");
            //     return;
            // }
        }
        Console.WriteLine("Print Job Completed");
    }

    static void UserInputCheck(CancellationTokenSource cts) {
        // Check for user input
        if(Console.ReadKey().KeyChar == ' ') {
            // Cancel the print job") {
            cts.Cancel();
        }
    } 
}
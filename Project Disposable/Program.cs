// See https://aka.ms/new-console-template for more information
// dispose, kemaren kan belajar GC.Collect() tuh buat ngerelease resource. Tapi supaya resourcenya langsung direlease
// kalau kita manggil Gc kan bikin program freeze, ini nggak disarankan, makanya make method.Dispose(). Biasanya digunakan buat suatu method yang open jaringan gtu, kaya stream
// using, sebenernya buat dispose juga, tapi semisal di dalam proses sebelum dispose itu ada error, maka dispose g akan kepanggil. Makanya kita pakai using.
// kaya function yang writemessageusing, itu kan ada try catch finally, nah kaya gtu kurang lebih proses di balik using, using jadi simplified tulisan code dari try catch finally aja sebenrnya
using System.Runtime.InteropServices.Marshalling;

class Program {
    static async Task Main(){
        Human human = new();
        // .GetAwaiter().GetResult();
        string result = await human.FetchingAPI();
        Console.WriteLine(result);
        human.WriteMessage("hmm aja deh",@"C:\Users\Batch 9\Desktop\Batch 9\hmmm.txt.txt");
        human.WriteMessage("hmm aja deh yaaa",@"C:\Users\Batch 9\Desktop\Batch 9\hmmm.txt.txt");
        Console.WriteLine("proses write sudah selesai");
        string readMessage =human.ReadMessage(@"C:\Users\Batch 9\Desktop\Batch 9\hmmm.txt.txt");
        Console.WriteLine(readMessage);
        Console.WriteLine("proses read sudah selesai");
    }
}


class Human  {
    public int age;

    // state for save if dispose already called. di bawah ini statenya :
    private bool disposedValue;

    // private virtual void 
    public void WriteMessage(string message,string path){
        StreamWriter stream = new(path);
        stream.WriteLine(message);
        stream.Dispose();
    }

    public void WriteMessageWithUsing(string message,string path){
        // StreamWriter stream = new(path);
        // try
        // {
        //     stream.WriteLine(message);
        // }
        // catch (System.Exception)
        // {
            
        //     throw;
        // }
        // finally{
        //     stream.Dispose();
        // }
        using (StreamWriter stream = new(path)){
            stream.WriteLine(message);
        }
    }

    public async Task<string> FetchingAPI(){
        string result;
        using ( HttpClient httpClient = new()){
          HttpResponseMessage response = await httpClient.GetAsync("https://catfact.ninja/fact");
          result = await response.Content.ReadAsStringAsync();
        }
        return result;
    }

     public string ReadMessage(string path){
        StreamReader stream = new(path);
        string result = stream.ReadLine();
        stream.Dispose();
        return result;
    }
}

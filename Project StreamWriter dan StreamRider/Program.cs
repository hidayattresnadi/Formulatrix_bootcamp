// // See https://aka.ms/new-console-template for more information
// class Program
// {
//     static async Task Main()
//     {
//         using (FileStream fs = new FileStream("test.txt", FileMode.Open))
//         {
//             using (StreamReader sr = new StreamReader(fs))
//             {
//                 string result = await sr.ReadToEndAsync();
//                 Console.WriteLine(result);
//             }
//         }
//         // using (FileStream fs = new FileStream("test.txt", FileMode.Create, FileAccess.Write))
//         // {
//         //     using (StreamWriter sw = new StreamWriter(fs))
//         //     {
//         //         // fs.Seek(0,SeekOrigin.End);
//         //         sw.WriteLine("Hello, World!");
//         //         sw.WriteLine("This is a sample text.");
//         //         sw.WriteLine("Using StreamWriter for writing to a file.");
//         //         sw.Flush();
//         //         Console.WriteLine("berhasill");
//         //     }
//         // }
//         using(FileStream fs = new FileStream("test.txt", FileMode.Create, FileAccess.Write)){
//             using(StreamWriter outputFile = new StreamWriter(fs)) // Set append = true
//             {
//                 outputFile.WriteLine("Hello world 6");
//                 fs.Seek(0, SeekOrigin.End);
//                 outputFile.WriteLine("Hello world 7");
//             }
//         }
//     }
// }

﻿class Program 
{
	static async Task Main() {
		using (FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate)) {
			using (StreamWriter sw = new StreamWriter(fs)) {
				sw.AutoFlush = true;
				fs.Seek(0, SeekOrigin.End);
				await sw.WriteLineAsync("Hello, World!");
				await sw.FlushAsync();
				// fs.Seek(-7, SeekOrigin.End);
				await sw.WriteLineAsync("Hello, World!");
				await sw.FlushAsync();
				await sw.WriteLineAsync("Hello, World!");	
				await sw.FlushAsync();
			}
		}
	}
}
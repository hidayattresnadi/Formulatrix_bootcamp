// See https://aka.ms/new-console-template for more information
using System.Text;
// semisal file mode create tapi file access read, maka dia errir exception read is invalid
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("wkkwkw");
            using (FileStream fs = new(@"./test1.txt", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                string text = "wkwkwkw";
                // membuat array baru yang menyimpan tipe data byte dengan size sesuai dengan text yang akan diubah jadi byte / encode
                byte[] myBytes = new byte[text.Length];
                // Proses encode, jadi array myBytes akan diassign dengan string text yang nanntinya diubah jadi tipe data bytes
                myBytes = Encoding.UTF8.GetBytes(text);
                // di bawah ini merupakan proses penulisan string di file baru, parameter pertama itu array of bytes si text,0 itu indeks start yang mau diambil, 0 itu berarti diambil dari index pertama
                // trus parameter terakhir merupakan batas sampai mana mau ditulisnya text di file baru tersebut, di sini karena pengen sampe ujung, ya make text.length
                fs.Write(myBytes, 0, myBytes.Length);
            }
            using (FileStream fs = new FileStream(@"./test1.txt",FileMode.Open,FileAccess.Read))
            {
                byte[] myBytes = new byte[fs.Length];
                fs.Read(myBytes,0,myBytes.Length);
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;
                while ((readLen = fs.Read(myBytes, 0, myBytes.Length)) > 0)
                {
                    Console.WriteLine(temp.GetString(myBytes, 0, readLen));
                }
            }
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

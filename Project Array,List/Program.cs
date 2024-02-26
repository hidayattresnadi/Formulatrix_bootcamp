// See https://aka.ms/new-console-template for more information
using System.Collections;

class Program
{
    static void Main()
    {
         // Tipe data  dan contoh
        // Array biasanya digunakan untuk menyimpan satu tipe data saja
        int[] namaArray = new int[4];
        int[] namaBebas = { 1, 2, 3, 4 };
        int[] namaDayat = [1, 2, 3, 4];
        namaArray[0] = 1;

        // ArrayList
        // sifatnya dynamic, not type safety, index

        ArrayList myArray = new();
        myArray.Add(1);
        myArray.Add(true);
        myArray.Add("hmmm");
        Console.WriteLine(myArray[0]);
        Console.WriteLine(myArray[1]);
        Console.WriteLine(myArray[2]);

        // List <T> sifatnya dynamic,index, dan type safety

        List<int> numbers = new();
        numbers.Add(2);
        numbers.Add(4);

        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);

        // Hashset, mirip seperti list tapi bisa disetting seolah nanti data yang ditambahkan harus unique
        // Hashset ada 3 tipe : Union with, Intersect with, Except with
        // Union with : gabung semua tapi g ada data duplikat
        // Intersect with hanya data yang sama 
        // Except with, jadi kaya data di luar itu ga bakal dimasukin
        // nah kalau hashset misalkan kita nambahin duplicat, ttp pertama yang dianggap, yang duplikat diabaikan

        HashSet<int> myhs = new();
        myhs.Add(1);
        myhs.Add(2);
        myhs.Add(3);
        myhs.Add(3);

        Console.WriteLine(myhs);

        // Linked list
        // jadi dipake buat nyimpen data yang nantinya nih data bisa disisipkan sama angka msial
        // soalnya kan klo ganti data biasanya replace data, nah ini sisipin aja


        LinkedList<int> myLL = new();
        myLL.AddLast(1);
        myLL.AddFirst(3);
        
        // Collection => key-value par

        // Dictionary<T key, T value>; 


        // Collection => dictionary mirip kaya object javascript
        Dictionary<int,string> dict = new();
        dict.Add(3,"foo");
        dict.Add(5,"bar");
        // dictionary unique dia, jadi semisal ada key diassign lagi, dia ga bakal mau jalan
        // dict.Add(5,"barrel");
        dict.Add(2,"foo");

        SortedDictionary<int,string> dayat = new(dict);

        Console.WriteLine(dict[3]);
        // Listkeyvaluepair

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }

        // Que dan Stack => collection
        // last in first out, ini si stack
        // Que first in, first out

        Stack<int> myStack = new();
        // push tuh berarti nambahin data di stacknya
        myStack.Push(2);
        myStack.Push(5);
        myStack.Push(4);
        // Pop menghilangkan data di index tertinggi
        myStack.Pop();
        // melihat data di index tertinggi
        myStack.Peek();

        Queue <int> myQueue = new();
        // Menambahkan data di queue
        myQueue.Enqueue(4);
        myQueue.Enqueue(2);
        myQueue.Enqueue(6);
        // Mengurangi data di queue dari urutan index terendah dan return data indeks terendah + 1
        myQueue.Dequeue();
        // myQueue.Dequeue();

        // Peek buat liat data di index tertinggi
        myQueue.Peek();

        Console.WriteLine(myQueue.Peek());
    }
}
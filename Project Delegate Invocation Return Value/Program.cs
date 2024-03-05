// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
public delegate void delegateBaru();

public enum Negara {
	Jepang=1,
	Amerika,
	China
}
public delegate int MyDelegate(int a, int b);
class Program 
{
	static void Main() 
	{
        // TryIntegerandDouble
		int a = 6;
		int b = 2;

		Calculator calculator = new();
		delegateBaru delegateDayat = calculator.wkwkwk;
		delegateDayat.Invoke();

		Negara saya = Negara.Jepang;
		int urutan = (int)saya;
		Console.WriteLine(urutan);

		int pilihNegara = 3;
		Negara apaYa = (Negara)pilihNegara;
		Console.WriteLine(apaYa);


		MyDelegate del = calculator.Add;
		del += calculator.Mul;
		del += calculator.Div;

        // Jadi delegate di bawah ini tuh base class dari delegate sistem, shingga apabila ingin data bertipe delegate
        // dapat ditulis seperti berikut 
        // GetInvocatinList return array of Objects dari delegate, jadinya tiap2 anggota dari suatu delegate
        // bisa kita dapatkan

		Delegate[] delegates = del.GetInvocationList();
        // cara membuat array di C#, karena berbasis objek, jadinya inisiasi arraynya make instance dari array
		int[] result = new int[delegates.Length];
		int index = 0;
        
        // foreach pertama untuk mengisi array result dengan hasil return metode yang ada di delegate
		foreach(MyDelegate i in delegates) 
		{
            // Invoke di sini untuk eksekusi function di dalam delegate, Supaya bisa satu2 diperoleh
            // karena kan delegate itu cuman eksekusi terakhir klo bukan void, bsa diakali seperti ini

			result[index] = i.Invoke(a, b);
			index++;
		}
        // foreach kedua untuk print aja sih hasil dari tiap delegate yang sudah ditampung di array result
		foreach(var i in result) 
		{
			Console.WriteLine(i);
		}

		MyDelegate finalDelegate;
        // finalDelegate diassign dengan array delegates index pertama, alias 0
		finalDelegate = (MyDelegate) delegates[0];
		for(int i = 1; i < delegates.Length; i++) 
		{
			finalDelegate += (MyDelegate) delegates[i];
		}
		int result2 = finalDelegate.Invoke(100, 5);
		Console.WriteLine(result2);
	}
}
class Calculator 
{
	public int Add(int a, int b) 
	{
		return a + b;
	}
	public int Mul(int a, int b) 
	{
		return a * b;
	}
	public int Div(int a, int b) 
	{
		return a / b;
	}
	public void wkwkwk(){
		Console.WriteLine("testing aja");
	}
}
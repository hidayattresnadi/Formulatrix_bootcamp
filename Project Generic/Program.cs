using System.Numerics;
class Program {
	static void Main() {
		var myCollection = new MyCollection<int,string,bool>(20);
		myCollection.AddElement(2,"two",false);
		myCollection.AddElement(4,"four",true);
		(int,string,bool) mytuple = myCollection.GetElement();

        // Item1,Item2,Item3 ini tuh properti dari tuplenya, makanya kita ga declare Item1 ga error kan 
        Console.WriteLine(mytuple.Item1);
        Console.WriteLine(mytuple.Item2);
        Console.WriteLine(mytuple.Item3);
		// mytuple.Item1.Dump();
		// mytuple.Item2.Dump();

        var calc = new Calculator<int>();
		int result = calc.Add(3,4);
        int result2 = calc.Minus(3,4);
        Console.WriteLine(result);
        Console.WriteLine(result2);
		// result.Dump();
		
	}
}

// Perhatikan class di bawah ini :setelah nama class tersebut terdapat buka kurung dan parameter diisi oleh T.
// T di sana itu termasuk ke generic declaration. jadi generic itu dibuat supaya class tersebut flexible bisa menerima berbagai tipe data.
// di sini jumlah T ada 2, berarti class dapat menerima generic dari 2 data. 
class MyCollection<T,T2,T3>{
	private T[] myArray;
	private T2[] myArray2;

    private T3[] myArray3;
	private int index = 0;

    // myArray = new T[count] => ini berarti myArray akan dibuat tipe data array integer berdasarkan length sebesar count
    
	public MyCollection(int count) {
		myArray = new T[count];
		myArray2 = new T2[count];
        myArray3=new T3[count];
	}
	public bool AddElement(T data, T2 data2,T3 data3) {
		if(index == myArray.Length-1) {
			return false;
		}
		myArray[index] = data;
		myArray2[index] = data2;
        myArray3[index] = data3;
		index++;
		return true;
	}
	//Tuple di sini digunakan untuk mengembalikan lebih dari satu ouptut
    // Jadi pada kasus d bawah ini, fungsi geElement akan mengembalikan 2 array yatitu
    // myArray dan myArray2
	public (T,T2,T3) GetElement() {
		return (myArray[index-1],myArray2[index-1],myArray3[index-1]);
	}
}
class Data<T,T2> {
	public T data;
	public T2 data2;
	public Data(T data, T2 data2) {
		this.data = data;
		this.data2 = data2;
	}
}

class Calculator {}
class Calculator<T>:Calculator 
	where T : INumber<T>
	{
	public T Add(T data1, T data2) {
		return data1 + data2;
	}

    public T Minus(T data1,T data2){
        return data1-data2;
    }
}
	
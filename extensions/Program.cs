// See https://aka.ms/new-console-template for more information
// Perbedaan static dan ga static : jadinya static itu hanya bisa diakses apabila nama classnya yang 
// dipanggil, sedangkan g ada static, itu bisa dipanggil hanya dengan menjadikan instance terlebih dahulu
// alias disimpan ke dalam suatu variable.

class Program {
    static void Main (){
    int a = 3;
	3.Dump();
	Console.WriteLine(3);
	
	3.Cetak();
	"3".Cetak();
	3.Bandingkan(4).Cetak();
    }
}
//Extension Methods
// class/struct/object + new method
static class NamaApapun {
	public static void Cetak(this object a)  {
		Console.WriteLine(a);
	}
	public static int Bandingkan(this int x, int y) {
		if(x>y) {
			return 1;
		}
		if(x<y) {
			return -1;
		}
		return 0;
	}
	public static void Dump(this object a) {
		Console.WriteLine(a);
	}
}

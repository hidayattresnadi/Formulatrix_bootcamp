// See https://aka.ms/new-console-template for more information
class Program {
    static void Main(){
        Calculator calc = new();
        int result = calc.Add(5,6);
        Console.WriteLine(result);
    }

}
///<summary>
///Calculator lalala
///</summary>
class Calculator {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>result of addition</returns>
    public int Add (int a,int b){
        return a+b;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>result of substraction</returns>
    public int Substract (int a,int b){
        return a-b;
    }
}

// XML documentation yang make /// biar disorot functionnya keliatan dia buat apa, kaya kasih keterangan
namespace Calculate;

class Calculator {

    private static int count;
    private int _balance;
	public object Add(object obj1, object obj2) {
		if(obj1 is int a && obj2 is int b) {
			count++;
            return a+b;
		}
		if(obj1 is string c && obj2 is string d) {
            count++;
			return c + d;
		}
		return null;
	}

    public static int GetCount(){
        return count; 
    }

    public int GetBalance(int balance){
        count++;
        return balance;
    }

    // jadi semisal parameternya flexible, misal penjumlahannya mau 3 angka parameter, 4 angka parameter

    public static int AdditionFlexible(params int [] numbers){
        int result = 0;
        for(int i = 0;i<numbers.Length;i++){
            result += numbers[i];
        }
        // foreach (var number in numbers)
        // {
        //     result += number;
        // }
        return result;
    }
}
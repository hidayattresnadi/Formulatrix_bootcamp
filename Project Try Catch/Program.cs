// See https://aka.ms/new-console-template for more information
class Program {
    static void Main (){
        {
		Console.WriteLine("Start Program");
		try { //Part of program will be executed
			ExceptionMaker();
            // ExecptionMaker2("123");
		}	
		catch(FormatException e) {
			Console.WriteLine("Ada format yang gagal");
		}
		catch(IndexOutOfRangeException e) {
            Console.WriteLine("Index diluar array");
		}
		catch(Exception e) {
			Console.WriteLine("Another exception happen");
		}
		Console.WriteLine("Finish Program");
	}

    }
    static void ExceptionMaker() {
		Console.WriteLine("Start Exception Maker Method");
		// string a = Console.ReadLine();
        string a = "z";
        int numberConvert = int.Parse(a);
        Console.WriteLine(numberConvert);
        // string a = "2"; ini bakal error indexOutOfRangeExecption
        // string a = "z"; ini bakal error formatException
		bool status = int.TryParse(a, out int index);
        Console.WriteLine(status);
		int[] myArray = {1,2,3};
		// if(index>myArray.Length-1) {
        //     return;
		// }
		Console.WriteLine(myArray[index]);
		
		Console.WriteLine("Finish Exception Maker Method");
	}

    static void ExecptionMaker2(string numberInputUser){
        Console.WriteLine("Start Program");
        bool status = int.TryParse(numberInputUser,out int result);
        if(result==0){
            return;
        }

        Console.WriteLine(result);
        Console.WriteLine(status);
        Console.WriteLine("Finish program");
    }
}

// See https://aka.ms/new-console-template for more information
// enum data type, jadi di sini itu untuk data-data yang pilihannya sudah disediakan, jadi ga mungkin
// bakal masuk data-data yang valuenya di luar dari nilai yang sudah disediakan
public enum StatusCode : int {
	NotFound = 404,
	Redirect = 300,
	Unauthorized = 401,
	InternalServerError = 500,
	OK = 200
}

public enum Game {

    StarRail =1,
    Genshin,
    Persona,
    LethalCompany
    
}
class Program {
	static void Main() {
		int x = 404;
		StatusCode code = (StatusCode)x;
		Console.WriteLine(code);

        CheckGame(Game.Genshin);

        int check = 2;
		Game gameToCheck = (Game)check;
		Console.WriteLine(gameToCheck);

        Game checkTest = Game.Genshin;
        int gameToos = (int)checkTest;
        Console.WriteLine(gameToos);

        Hewan sapi = Hewan.Sapi;
        int nilaiSapi = (int)sapi;
        Console.WriteLine(nilaiSapi);

        int nomorHewan = 3;
        Hewan namaHewan =(Hewan)nomorHewan;
        Console.WriteLine(namaHewan);



		// Array result = Enum.GetValues(typeof(StatusCode));
		// foreach(object? i in result) 
		// {
		// 	Console.WriteLine(i);
		// }
	}

    static void CheckGame (Game game) {
        if(game == Game.Genshin) {
            Console.WriteLine("Shogun");
        }
        else if(game == Game.StarRail){
            Console.WriteLine("Acheron");
        }
    }
}


public enum Hewan{
    Kambing =1,
    Ayam,
    Sapi,
    Kelinci,
    Kuda
}


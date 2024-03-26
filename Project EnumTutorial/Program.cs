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

public enum Tile {
        D = 2,
        G = 2,
        B = 3,
        C = 3,
        M = 3
}

class TileScrabble {
    public int idTile;
    public string huruf;

    public Tile1 tile;

    public enum Tile1 {
        D = 2,
        G = 2,
        B = 3,
        C = 3,
        M = 3
}
}

public enum Game {

    StarRail =1,
    Genshin,
    Persona,
    LethalCompany
    
}
class Program {
	static void Main() {
        TileScrabble newBiji = new();
        newBiji.idTile=1;
        newBiji.tile=TileScrabble.Tile1.D;
        newBiji.huruf=newBiji.tile.ToString();
        Console.WriteLine(newBiji.huruf);
        Console.WriteLine(newBiji.tile);
        // TileScrabble.Tile1 newBiji2 = TileScrabble.Tile1.M;
        
		int x = 404;
		StatusCode code = (StatusCode)x;
		Console.WriteLine(code);

        // Tile huruf = Tile.D;
        int angka = (int)Tile.C;
        Console.WriteLine(angka);

        CheckGame(Game.Genshin);

        int check = 2;
		Game gameToCheck = (Game)check;
		Console.WriteLine(gameToCheck);

        Game checkTest = Game.Genshin;
        int gameToos = (int)checkTest;
        Console.WriteLine(gameToos);





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

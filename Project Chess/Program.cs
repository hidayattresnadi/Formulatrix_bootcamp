// See https://aka.ms/new-console-template for more information
class Program {
    static void Main(){
        GameController gameController = new();
        IPlayer player1 = new("dayat");
        IPlayer player2 = new("Irham");
        
        var dictPlayer = gameController.AssignPlayerColourSet(player1,Colour.Black,player2,Colour.White);
        foreach (var item in dictPlayer)
        {
            Console.WriteLine($"{item.Key.PlayerHuman} memiliki warna {item.Value}");
        }
    }
}

// See https://aka.ms/new-console-template for more information
using log4net;
using log4net.Config;
using GameControllerLib;

class Program
{
    private static readonly ILog log = LogManager.GetLogger(typeof(Program));
    static void Main()
    {
        // Set up a simple configuration that logs on the console.
        // XmlConfigurator.Configure(new System.IO.FileInfo("./File.Config")); => make log4net ini define path File.Confignya
        BasicConfigurator.Configure();

        IPlayer p1 = new Player("dayat");
        p1.SetName("R");
        ICard cardNine = new Card(2, "Two heart");
        // ICard cardTen = new Card(10, "Ten heart");
        ICard cardEight = new Card(8, "Eight heart");
        ICard[] cards = new ICard[3];
        cards[0] = new Card(9, "Nine heart");
        cards[1] = new Card(10, "Ten heart");
        cards[2] = cardEight;
        log.Info("Card has been made");
        IBoard board = new Board(20);
        log.Info("Preparing application.");
        GameController gc = new(p1, board);
        gc.AddCards(p1,cards);
        gc.GetCards(p1);
        log.Info("player can get card.");
        gc.RemoveCard(p1,cardNine);
        gc.RemoveCard(p1,cardEight);
        log.Info("player success remove card");
        // gc.RemoveCard(p1,);
        log.Info("Exiting application.");
    }
}

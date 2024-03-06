class GameController
{
    // private Board
    public Dictionary<IPlayer, Colour> AssignPlayerColourSet(IPlayer p1, Colour colourC1, IPlayer p2,Colour colourC2)
    {
        Dictionary<IPlayer, Colour> dict = new();
        dict.Add(p1,colourC1);
        dict.Add(p2,colourC2);
        return dict;
    }
}

class IPlayer {
    public string PlayerHuman {get;set;}
    public IPlayer(string name){
        PlayerHuman=name;
    }
}

class PlayerData {
    public enum PlayerColour;
    public int PlayerMaterial;
    // public Dictionary <PeriodicTimer,Location> PlayerPIeces;
}

public enum Colour{
    Black,
    White
}

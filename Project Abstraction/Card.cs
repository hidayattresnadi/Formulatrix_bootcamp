abstract class Card {
    private int id;
    private string name;
    private string colour;

    public Card (int id,string name,string colour){
        this.id=id;
        this.name=name;
        this.colour=colour;
    }

    public int GetId(){
        return id;
    }

    public string GetName(){
        return name;
    }

    public string GetColour(){
        return colour;
    }

    public abstract void StartEffect();
}

class ElectricPaid : Card {
    public ElectricPaid(int id,string name,string colour) : base (id,name,colour){}

    public override void StartEffect()
    {
        Console.WriteLine("Electricity card effect starting...");
    }
}

class BirthdayCard : Card {
	public BirthdayCard(int id, string name, string colour) : base(id, name, colour) {
	
	}
	public override void StartEffect() {
		Console.WriteLine("Birthday card effect starting...");
	}
}
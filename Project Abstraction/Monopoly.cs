class MonopolyGameController{
	private Card[] cards;
	private int count = 0;
	public MonopolyGameController(int card) {
		cards = new Card[card];
	}
	public bool AddCard(Card card) {
		cards[count] = card;
		count++;
		return true;
	}

    public string []  GetCards(){
        string[] cardNames = new string[2];
        cardNames[0]=cards[0].GetName();
        return cardNames;
    }
}
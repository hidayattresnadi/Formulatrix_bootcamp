namespace GameControllerLib;
using NLog;

public class GameController
{
    public static Logger logger = LogManager.GetCurrentClassLogger();
	private Dictionary<IPlayer, HashSet<ICard>> _players;
	private IBoard _board;
	public event Action<ICard>? OnCardUpdate;

	public GameController(IPlayer player, IBoard board)
	{
		_players = new()
			{
				{ player, new HashSet<ICard>()}
			};
		_board = board;
		logger.Info("GameController created");
	}

	public bool AddCards(IPlayer player, params ICard[] cards)
	{
		if (!_players.TryGetValue(player, out HashSet<ICard>? playerCards))
		{
			return false;
		}
		foreach (var card in cards)
		{
			playerCards.Add(card);
			ChangeCardStatus(card, CardStatus.OnPlayer);
		}
        logger.Info("Add card succeed");
		return true;
	}

	public IEnumerable<ICard> GetCards(IPlayer player)
	{
		if (!_players.ContainsKey(player))
		{
            logger.Error("Player is not found");
			return Enumerable.Empty<ICard>();
		}
		return _players[player];
	}

	public bool RemoveCard(IPlayer player, ICard card)
	{
		if (!_players.ContainsKey(player))
		{
            logger.Warn($"{player} is not found when remove card");
			return false;
		}

		if (!_players[player].Contains(card))
		{
            logger.Error("Card is not found");
			return false;
		}
		_players[player].Remove(card);
		ChangeCardStatus(card, CardStatus.Removed);
		return true;
	}

	public void ChangeCardStatus(ICard card, CardStatus status)
	{
		card.SetStatus(status);
		OnCardUpdate?.Invoke(card);
        logger.Info("Card success to change status");
	}
}
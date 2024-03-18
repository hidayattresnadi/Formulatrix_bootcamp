namespace GameControllerLib;
using log4net;
public class Player : IPlayer
{
    private static readonly ILog log = LogManager.GetLogger(typeof(Player));
	private string _name;
	public Player(string name) 
	{
		_name = name;
	}
	public string GetName()
	{
		return _name;
	}

	public void SetName(string name)
	{
		if(name.Length > 2) {
			_name = name;
            log.Info("Name is right");
		}
        log.Error("error name length is not enough");
	}
	public override string ToString()
	{
		return _name;
	}
}
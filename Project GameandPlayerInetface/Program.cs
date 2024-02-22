// di sini jadi semisal class Monopoly game itu merujuk contrak ke Iplayer, dimana informasi player hanya id dan name
// sedangkan pada class mobile legend game, itu para playernya pasti punya email, nickname. Jadinya
// tentu mobile legend game g akan bisa kalau make kontrak dari Iplayer, maka di sini dibikin kontrak baru yaitu IOnlinePlayer
// dimana IOnlinePlayer dapat memenuhi kriteria dari MobileLegendGame

// pada class MonopolyGame, dikarenakan hanya class Iplayer saja yang bisa masuk, maka apabila class lain yang bukan Iplayer
// dan inherit dari Iplayer maka tidak akan bisa masuk ke dalam class MonopolyGame ini
class MonopolyGame {
	IPlayer[] players;
	public void AddPlayer(IPlayer p) {
		//...
		//players + p
	}
}

// jadi yang inherit dari IOnlinePlayer seperti class PubgPlayer dan Online player, itu dapat masuk ke kelas di bawah
// sebab MobileLegendGame persyaratannya yaitu tipe data IOnlinePlayer sedangkan class Player itu tidak bisa karena bukan kontrak IOnlinePlayer
class MobileLegendGame {
	IOnlinePlayer[] onlinePlayers;
	public void AddPlayer(IOnlinePlayer p) {
		//...
		//onlinePlayers + p
	}
	public string CheckUsername(IOnlinePlayer p) {
		//...
		return p.UserName;
	}
}
public interface IPlayer {
	public int ID {get;set;}
	public string Name {get;set;}
}

// di sini, karena IOnlinePlayer ada kesamaan dengan Iplayer, yaitu pada Iplayer, maka IOnlinePlayer
// dapat inherit dari Iplayer, seperti di bawah
public interface IOnlinePlayer : IPlayer {
	public string UserName {get;set;}
	public string Email {get;set;}
}
class Player : IPlayer {
	public int ID {get;set;}
	public string Name {get;set;}
}
class OnlinePlayer : IOnlinePlayer {
	public int ID {get;set;}
	public string Name {get;set;}
	public string UserName {get;set;}
	public string Email {get;set;}
}
class PUBGPlayer : IOnlinePlayer {
	public int ID {get;set;}
	public string Name {get;set;}
	public string UserName {get;set;}
	public string Email {get;set;}
	public string Rank {get;set;}
}

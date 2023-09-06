namespace Game;

public class OnlinePlayer : IPlayer, IOnline
{
	private float _kda = 10.99f;
	private float _winRate = 0.99f;
	private string _rareSkin = "C:/Battlefield9/Assets/RareSkin.png";
	public float GetKDA() 
	{
		return _kda;
	}
	public float GetWinRate() 
	{
		return _winRate;
	}
	public string GetWeaponSkin() 
	{
		return _rareSkin;
	}
}

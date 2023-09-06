namespace Game;

public class OnlinePlayer : IPlayer, IOnline
{
	private float kda = 10.99f;
	public float GetKDA() 
	{
		return kda;
	}
	public float GetWinRate() 
	{
		return 0.99f;
	}
	public string GetWeaponSkin() 
	{
		return "C:/Battlefield9/Assets/RareSkin.png";
	}
}

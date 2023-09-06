namespace Game;

public class OfflinePlayer : IPlayer
{
	private string rareSkin = "C:/Battlefield9/Assets/RareSkin.png";
	private float storyProgress = 0.5f;
	public float GetStoryProgress() 
	{
		return storyProgress;
	}
	
	public string GetWeaponSkin() 
	{
		return rareSkin;
	}
}

namespace Game;

public class OfflinePlayer : IPlayer
{
	private string _rareSkin = "C:/Battlefield9/Assets/RareSkin.png";
	private float _storyProgress = 0.5f;
	public float GetStoryProgress() 
	{
		return _storyProgress;
	}
	
	public string GetWeaponSkin() 
	{
		return _rareSkin;
	}
}

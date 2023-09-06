namespace Game;

public class Battlefield
{
	public float kda, winRate, storyProgress;
	public string weaponSkin;
	public Battlefield(float storyProgress, string weaponSkin) 
	{
		this.storyProgress = storyProgress;
		this.weaponSkin = weaponSkin;
	}
	public Battlefield(float kda, float winRate, string weaponSkin) 
	{
		this.kda = kda;
		this.winRate = winRate;
		this.weaponSkin = weaponSkin;
	}
	public void LoadGame() 
	{
		Console.WriteLine("Game is loading..");
		Console.WriteLine($"Load skin in {weaponSkin}");
	}
	public void PlayGame() 
	{
		Console.WriteLine("Game loaded, you can play game.");
	}
	public void StopGame() 
	{
		Console.WriteLine("Game stopped.");
	}
}

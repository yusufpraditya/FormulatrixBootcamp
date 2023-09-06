namespace Game;

public class Battlefield
{
	public float kda, winRate, storyProgress;
	public string weaponSkin;
	public bool isOnline;
	public Battlefield(float storyProgress, string weaponSkin) 
	{
		this.storyProgress = storyProgress;
		this.weaponSkin = weaponSkin;
		isOnline = false;
	}
	public Battlefield(float kda, float winRate, string weaponSkin) 
	{
		this.kda = kda;
		this.winRate = winRate;
		this.weaponSkin = weaponSkin;
		isOnline = true;
	}
	public void LoadGame() 
	{
		if (isOnline) 
		{
			Console.WriteLine("Online game is loading..");
			Console.WriteLine($"Load skin in {weaponSkin}");
			Console.WriteLine($"Your KDA is {kda}.");
			Console.WriteLine($"Your win rate is {winRate}.");
		} else 
		{
			Console.WriteLine("Offline game is loading..");
			Console.WriteLine($"Load skin in {weaponSkin}");
			Console.WriteLine($"Your story progress is {storyProgress * 100}%.");
		}
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

using Game;
public class Program 
{
	static void Main() 
	{
		// Play offline game
		OfflinePlayer offlinePlayer = new();
		float storyProgress = offlinePlayer.GetStoryProgress();
		string weaponSkin = offlinePlayer.GetWeaponSkin();
		
		Battlefield offlineGame = new Battlefield(storyProgress, weaponSkin);
		offlineGame.LoadGame();
		offlineGame.PlayGame();
		offlineGame.StopGame();
		
		Console.WriteLine();
		
		// Play online game
		OnlinePlayer onlinePlayer = new();
		float kda = onlinePlayer.GetKDA();
		float winRate = onlinePlayer.GetWinRate();
		
		Battlefield onlineGame = new Battlefield(kda, winRate, weaponSkin);
		onlineGame.LoadGame();
		onlineGame.PlayGame();
		onlineGame.StopGame();
		
	}
}
using EventHandlerGeneric;

public class Program 
{
	static void Main() 
	{
		Youtuber yt = new Youtuber("Windah Basudara");
		Subscriber sub1 = new Subscriber("Yusuf");
		
		yt.notificationHandler += sub1.GetNotification;
		yt.trendingHandler += sub1.ViewReached;
		
		yt.UploadVideo("Game Horror");
		yt.UploadVideo("Game Bocil");
		yt.UploadVideo("Game Sus");
		
		// todo: fix trending video bug
		sub1.GetVideoList();
		sub1.WatchVideo(yt.trendingHandler, 1, 500000);
		sub1.WatchVideo(yt.trendingHandler, 2, 500000);
		sub1.WatchVideo(yt.trendingHandler, 1, 500000);
		
		
	}
}
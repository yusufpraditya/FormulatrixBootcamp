using EventHandlerGeneric;

public class Program 
{
	static void Main() 
	{
		Server serverID = new Server();
		Youtuber yt1 = new Youtuber("Windah Basudara");
		Youtuber yt2 = new Youtuber("IShowSpeed");
		Subscriber sub1 = new Subscriber("Yanto", serverID);
		Subscriber sub2 = new Subscriber("Burhan", serverID);
		
		yt1.notificationHandler += sub1.GetNotification;
		sub1.trendingHandler += serverID.ViewReached;
		
		yt2.notificationHandler += sub1.GetNotification;
		sub2.trendingHandler += serverID.ViewReached;
		
		yt1.UploadVideo("Game Horror");
		yt1.UploadVideo("Game Bocil");
		yt1.UploadVideo("Game Sus");
		yt2.UploadVideo("Game Bola");
		
		sub1.GetVideoList();
		sub1.WatchVideo(1, 1500000);
		sub1.WatchVideo(2, 1200000);
		sub1.WatchVideo(4, 1100000);
		sub1.WatchVideo(3, 1000000);
		sub1.GetTrendingVideo();
		
		sub2.GetVideoList();
		sub2.WatchVideo(4, 110000);
		sub2.GetTrendingVideo();
	}
}
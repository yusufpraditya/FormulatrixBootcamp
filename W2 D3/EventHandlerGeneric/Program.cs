using EventHandlerGeneric;

public class Program 
{
	static void Main() 
	{
		Youtuber yt = new Youtuber("Windah Basudara");
		Subscriber sub1 = new Subscriber("Yusuf");
		
		yt.AddSubscriber(sub1.GetNotification);
		yt.UploadVideo("Game Horror");
		
		yt.AddViewCount(sub1.WatchVideo);
		
	}
}
using EventHandlerExample;
public class Program 
{
	static void Main() 
	{
		Youtuber yt1 = new Youtuber("Windah Basudara");
		Subscriber sub1 = new Subscriber("Yusuf");
		
		yt1.AddSubscriber(sub1.GetNotification);
		yt1.UploadVideo();
	}
}
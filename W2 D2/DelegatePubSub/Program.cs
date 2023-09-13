using DelegatePubSub;
public delegate void Publish(string x);
public class Program 
{
	static void Main() 
	{
		Youtuber yt = new();
		Subscriber sub1 = new();
		
		yt.AddSubscriber(sub1.Notify);
		yt.SendNotification();

		yt.RemoveSubscriber(sub1.Notify);
	}
}
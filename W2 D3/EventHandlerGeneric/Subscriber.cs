namespace EventHandlerGeneric;
public class Subscriber
{
	private string? _name;
	private int _trendingThreshold = 1000000;
	EventData data = new();
	
	public Subscriber(string name) 
	{
		_name = name;
	}
	
	public void WatchVideo(EventHandler<EventData> trendingHandler, int times) 
	{
		Console.WriteLine($"{_name} is watching youtube video {times} times.");
		data.viewCount += times;
		if (data.viewCount >= _trendingThreshold) 
		{
			if (trendingHandler != null) 
			{
				trendingHandler.Invoke(this, data);	
			}
		}
	}
	
	public void GetNotification(object? sender, EventData e) 
	{
		Console.WriteLine(e.message);
	}
	
	public void ViewReached(object? sender, EventData e) 
	{
		Console.WriteLine($"Video has reached {e.viewCount} and is now #1 Trending");
	}
}

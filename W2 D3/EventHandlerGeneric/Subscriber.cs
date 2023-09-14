namespace EventHandlerGeneric;
public class Subscriber
{
	private string? _name;
	private int _trendingThreshold = 1000000;
	public EventHandler<EventData>? videoDictHandler;
	public EventData data = new();
	
	public Subscriber(string name) 
	{
		_name = name;
	}
	
	public void WatchVideo(EventHandler<EventData> trendingHandler, int videoIndex, int times) 
	{
		Console.WriteLine($"{_name} is watching {EventData.videoDict?.GetValueOrDefault(videoIndex)} {times} times.");
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
	
	public void GetVideoList() 
	{
		Console.WriteLine("Video List");
		if (EventData.videoDict != null) {
			foreach (var kvp in EventData.videoDict) {
				Console.WriteLine($"{kvp.Key}. {kvp.Value}");
			}
		}
	}
	
	public void ViewReached(object? sender, EventData e) 
	{
		Console.WriteLine($"Video has reached {e.viewCount} views and is now #1 Trending.");
	}
}

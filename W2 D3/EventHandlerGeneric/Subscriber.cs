namespace EventHandlerGeneric;
public class Subscriber
{
	private string? _name;
	EventData data = new();
	
	public Subscriber(string name) 
	{
		_name = name;
	}
	
	public void WatchVideo(object? sender, EventData e) 
	{
		Console.WriteLine($"{_name} is watching youtube video");
		data.viewCount += 1;
	}
	
	public void GetNotification(object? sender, EventData e) 
	{
		Console.WriteLine(e.message);
	}
	
	// public void GetViewCount(object? sender, EventData e) 
	// {
	// 	Console.WriteLine($"Youtube view count: {e.viewCount}");
	// }
}

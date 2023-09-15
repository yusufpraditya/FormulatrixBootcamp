namespace EventHandlerGeneric;
public class Youtuber
{
	public static int videoIndex;
	private string? _name;
	public static Dictionary<int, string> videoDict = new();
	public static Dictionary<int, int> trendingDict = new();
	public EventHandler<DataEventArgs>? notificationHandler;
	//public EventHandler<DataEventArgs>? trendingHandler;
	public EventHandler<DataEventArgs>? videoHandler;
	
	public Youtuber(string name) 
	{
		_name = name;
	}
	
	public void UploadVideo(string title) 
	{
		title += $" ({_name})";
		videoIndex += 1;
		videoDict.Add(videoIndex, title);
		Console.WriteLine($"[Youtuber] Video with title {title} is being uploaded..");
		Console.WriteLine("[Youtuber] Video uploaded.");
		SendNotification(title);
	}
	
	private void SendNotification(string title) 
	{
		if (notificationHandler != null) 
		{
			notificationHandler.Invoke(this, new DataEventArgs {message = $"[Subscriber] Youtube Notification: {title}"});
		}
	}
	public override string? ToString()
	{
		return _name;
	}
}
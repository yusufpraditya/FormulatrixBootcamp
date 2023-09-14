namespace EventHandlerGeneric;
public class Youtuber
{
	private int _videoIndex;
	private EventData? _data = new();
	public EventHandler<EventData>? notificationHandler;
	public EventHandler<EventData>? trendingHandler;
	public EventHandler<EventData>? videoHandler;
	private string? _name;
	
	public Youtuber(string name) 
	{
		_name = name;
	}
	
	public void UploadVideo(string title) 
	{
		_videoIndex += 1;
		EventData.videoDict?.Add(_videoIndex, title);
		Console.WriteLine($"Video with title {title} is being uploaded..");
		Console.WriteLine("Video uploaded.");
		SendNotification(title);
	}
	
	private void SendNotification(string title) 
	{
		if (notificationHandler != null) 
		{
			notificationHandler.Invoke(this, new EventData {message = $"Youtube Notification: {this} - {title}"});
		}
	}
	public override string? ToString()
	{
		return _name;
	}
}
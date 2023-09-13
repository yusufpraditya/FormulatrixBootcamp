namespace EventHandlerGeneric;
public class Youtuber
{
	private EventHandler<EventData>? _sub;
	private EventHandler<EventData>? _viewCount;
	private string? _name;
	
	public Youtuber(string name) 
	{
		_name = name;
	}
	
	public void GetViewCount() 
	{
		
	}
	
	
	
	public void UploadVideo(string title) 
	{
		Console.WriteLine($"Video with title {title} is being uploaded..");
		Console.WriteLine("Video uploaded.");
		SendNotification(title);
	}
	
	private void SendNotification(string title) 
	{
		if (_sub != null) 
		{
			_sub.Invoke(this, new EventData {message = $"Youtube Notification: {this} - {title}"});
		}
	}
	
	public void AddSubscriber(EventHandler<EventData>? sub) 
	{
		if (_sub == null || !_sub.GetInvocationList().Contains(sub)) 
		{
			_sub += sub;
		}
		else 
		{
			Console.WriteLine("Error: Subscriber already exist.");
		}
	}
	
	public void RemoveSubscriber(EventHandler<EventData>? sub) 
	{
		if (_sub != null) 
		{
			_sub -= sub;
		}
		else 
		{
			Console.WriteLine("Error: No subscriber.");
		}
	}
	
	public void AddViewCount(EventHandler<EventData>? viewCount) 
	{
		if (_viewCount == null || !_viewCount.GetInvocationList().Contains(viewCount)) 
		{
			_viewCount += viewCount;
		}
	}
	public override string? ToString()
	{
		return _name;
	}
}

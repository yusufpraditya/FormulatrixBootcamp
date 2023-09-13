namespace EventHandlerExample;
public class Youtuber
{
	private EventHandler? _sub;
	private string _name;
	
	public Youtuber(string name) 
	{
		_name = name;
	}
	
	public void AddSubscriber(EventHandler sub) 
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
	
	public void RemoveSubscriber(EventHandler sub) 
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
	
	public void UploadVideo() 
	{
		Console.WriteLine("Video is being uploaded..");
		Console.WriteLine("Video uploaded.");
		SendNotification();
	}
	
	private void SendNotification() 
	{
		if (_sub != null) 
		{
			_sub.Invoke(this, EventArgs.Empty);
		}
	}
    public override string ToString()
    {
        return _name;
    }
}

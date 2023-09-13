namespace DelegatePubSub;
public class Youtuber
{
	private Publish? _sub;
	public void SendNotification() 
	{
		if (_sub != null) 
		{
			_sub.Invoke("Notify");
		}
	}
	
	public void AddSubscriber(Publish sub) 
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
	
	public void RemoveSubscriber(Publish sub) 
	{
		if (_sub != null) 
		{
			_sub -= sub;
		} else 
		{
			Console.WriteLine("Error: No subscriber.");
		}
	}
}

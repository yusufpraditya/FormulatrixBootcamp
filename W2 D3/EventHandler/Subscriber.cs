namespace EventHandlerExample;
public class Subscriber
{
	private string? _name;
	
	public Subscriber(string name) 
	{
		_name = name;
	}
	
	public void GetNotification(object? sender, EventArgs e) 
	{
		
		Console.WriteLine($"{_name} is getting notification from Youtuber ({sender}).");
	}
}

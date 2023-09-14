namespace EventHandlerGeneric;
public class EventData : EventArgs
{
	public string? message;
	public int viewCount; // todo: change this to dictionary
	public static Dictionary<int, string>? videoDict = new();
}

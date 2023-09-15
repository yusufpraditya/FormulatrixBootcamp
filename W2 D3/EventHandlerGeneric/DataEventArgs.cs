namespace EventHandlerGeneric;
public class DataEventArgs : EventArgs
{
	public string? message;
	public int videoIndex;
	public Dictionary<int, int> viewCount = new();
}

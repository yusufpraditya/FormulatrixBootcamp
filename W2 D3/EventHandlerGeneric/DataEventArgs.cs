namespace EventHandlerGeneric;
public class DataEventArgs : EventArgs
{
	public int videoIndex;
	public string? videoTitle;
	public Dictionary<int, int> viewCount = new();
}

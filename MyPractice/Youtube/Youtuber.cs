namespace Youtube;
public class Youtuber : IUpload, IWatch
{
	public static int videoIndex;
	private string? _name;
	private Server _server = new();
	public static Dictionary<int, string> videoDict = new();
	public static Dictionary<int, int> trendingDict = new();
	public EventHandler<DataEventArgs>? uploadHandler;
	
	public Youtuber(string name, Server server) 
	{
		_name = name;
		_server = server;
		uploadHandler += _server.UploadFinished;
	}
	
	public void UploadVideo(string videoTitle) 
	{
		Console.WriteLine($"[Youtuber] {_name} tried to upload new video with title {videoTitle}.");
		videoTitle += $" ({_name})";
		videoIndex += 1;
		videoDict.Add(videoIndex, videoTitle);
		UploadToServer(videoIndex, videoTitle);
	}
	
	private void UploadToServer(int videoIndex, string videoTitle) 
	{
		_server.data.videoIndex = videoIndex;
		_server.data.videoTitle = videoTitle;
		if (uploadHandler != null) uploadHandler.Invoke(this, _server.data);
	}
	
	public void WatchVideo(int videoIndex, int times) 
	{
		_server.data.videoIndex = videoIndex;
		Console.WriteLine($"[Youtuber] {_name} is watching {videoDict.GetValueOrDefault(videoIndex)} {times} times.");
		if (_server.data.viewCount.ContainsKey(videoIndex)) 
		{
			_server.data.viewCount[videoIndex] += times;
		} 
		else 
		{
			_server.data.viewCount.Add(videoIndex, times);
		}
	}
}
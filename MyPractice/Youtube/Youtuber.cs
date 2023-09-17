namespace Youtube;
public class Youtuber : IUpload, IWatch
{
	public static int videoIndex;
	private string _name;
	private Server _server = new();
	public static Dictionary<int, string> videoDict = new();
	public static Dictionary<int, int> trendingDict = new();
	public EventHandler<DataEventArgs>? uploadHandler;
	public EventHandler<DataEventArgs>? trendingHandler;
	
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
		bool success = videoDict.TryGetValue(videoIndex, out string? title);
		if (success) 
		{
			Console.WriteLine($"[Youtuber] {_name} is watching {title} {times} times.");
			if (!title.Contains(_name)) 
			{
				_server.data.videoIndex = videoIndex;
				if (_server.data.viewCount.ContainsKey(videoIndex)) 
				{
					_server.data.viewCount[videoIndex] += times;
				} 
				else 
				{
					_server.data.viewCount.Add(videoIndex, times);
				}
				if (_server.data.viewCount.GetValueOrDefault(videoIndex) >= _server.TrendingThreshold && trendingHandler != null) 
				{
					trendingHandler.Invoke(this, _server.data);	
				}
			}
		}
		else 
		{
			Console.WriteLine("The video is unavailable!");
		}
	}
	
	public void GetVideoList() 
	{
		Console.WriteLine($"\n[Youtuber] {_name} is looking at the Video List to watch..");
		Console.WriteLine("[Video List]");
		foreach (var kvp in videoDict) {
			Console.WriteLine($"{kvp.Key}. {kvp.Value}");
		}
		Console.WriteLine();
	}
	
	public void GetTrendingVideo() 
	{
		Console.WriteLine("\n[Trending Video]");
		List<Trending> trendingList = _server.GetTrendingList();
		int trendingNumber = 0;
		foreach (var item in trendingList) 
		{
			trendingNumber += 1;
			Console.WriteLine($"{trendingNumber}. {videoDict.GetValueOrDefault(item.VideoIndex)} - {item.ViewCount} views");
		}
		Console.WriteLine();
	}
}
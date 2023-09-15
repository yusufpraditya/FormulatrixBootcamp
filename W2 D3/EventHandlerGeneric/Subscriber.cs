using System.Data;

namespace EventHandlerGeneric;
public class Subscriber
{
	private string? _name;
	private int _trendingThreshold = 1000000;
	//public EventHandler<DataEventArgs>? videoDictHandler;
	private Server _server = new();
	public EventHandler<DataEventArgs>? trendingHandler;

	public Subscriber(string name, Server server) 
	{
		_name = name;
		_server = server;
	}
	
	public void WatchVideo(int videoIndex, int times) 
	{
		_server.data.videoIndex = videoIndex;
		Console.WriteLine($"[Subscriber] {_name} is watching {Youtuber.videoDict.GetValueOrDefault(videoIndex)} {times} times.");
		if (_server.data.viewCount.ContainsKey(videoIndex)) 
		{
			_server.data.viewCount[videoIndex] += times;
		} 
		else 
		{
			_server.data.viewCount.Add(videoIndex, times);
		}
		if (_server.data.viewCount.GetValueOrDefault(videoIndex) >= _trendingThreshold && trendingHandler != null) 
		{
			trendingHandler.Invoke(this, _server.data);	
		}
	}
	
	public void GetNotification(object? sender, DataEventArgs e) 
	{
		Console.WriteLine(e.message);
	}
	
	public void GetVideoList() 
	{
		Console.WriteLine($"\n[Subscriber] {_name} is looking at the Video List to watch..");
		Console.WriteLine("[Video List]");
		foreach (var kvp in Youtuber.videoDict) {
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
			Console.WriteLine($"{trendingNumber}. {Youtuber.videoDict.GetValueOrDefault(item.VideoIndex)} - {item.ViewCount} views");
		}
		Console.WriteLine();
	}
}

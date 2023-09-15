namespace EventHandlerGeneric;

public class Server
{
	private static int _trendingThreshold = 1000000;
	public DataEventArgs data = new();

	public List<Trending> GetTrendingList() 
	{
		List<Trending> trendingList = new List<Trending>();
		foreach (var kvp in data.viewCount) 
		{
			if (kvp.Value >= _trendingThreshold) trendingList.Add(new Trending(){VideoIndex = kvp.Key, ViewCount = kvp.Value});
		}
		trendingList.Sort();
		trendingList.Reverse();
		return trendingList;
	}
	
	public void ViewReached(object? sender, DataEventArgs e) 
	{
		List<Trending> trendingList = GetTrendingList();		
		int number = 0;
		int trendingNumber = 0;
		foreach (var item in trendingList) 
		{
			number += 1;
			if (item.VideoIndex == e.videoIndex) 
			{
				trendingNumber = number;
			}
		}
		Console.WriteLine($"[Server] Video {Youtuber.videoDict.GetValueOrDefault(e.videoIndex)} has reached {e.viewCount.GetValueOrDefault(e.videoIndex)} views and is now #{trendingNumber} Trending.");
	}
}

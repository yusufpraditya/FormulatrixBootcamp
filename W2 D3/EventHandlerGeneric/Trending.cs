namespace EventHandlerGeneric;

public class Trending : IComparable<Trending>
{
	public int VideoIndex { get; set; }
	public int ViewCount { get; set; }
	
	public int CompareTo(Trending? compareTrending)
	{
		if (compareTrending == null)
			return 1;
		else
			return ViewCount.CompareTo(compareTrending.ViewCount);
	}
}

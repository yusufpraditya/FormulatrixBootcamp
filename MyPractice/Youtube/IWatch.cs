namespace Youtube;

public interface IWatch
{
	void WatchVideo(int videoIndex, int times);
	void GetVideoList();
	void GetTrendingVideo();
}

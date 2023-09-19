namespace List;

public class Car
{
	private string _brandName;
	private int _topSpeed;
	
	public string BrandName 
	{
		get => _brandName;
		set => _brandName = value;
	}
	
	public int TopSpeed
	{
		get => _topSpeed;
		set => _topSpeed = value;
	}
	
	public Car(string brandName, int topSpeed) 
	{
		_brandName = brandName;
		_topSpeed = topSpeed;
	}
}
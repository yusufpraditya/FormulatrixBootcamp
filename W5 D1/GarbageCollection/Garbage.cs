namespace GarbageCollection;

public class Garbage
{
	public void CreateGarbage(int maxGarbage) 
	{
		Car car;
		for (int i = 0; i < maxGarbage; i++) 
		{
			car = new("Ferrari");
		}
	}
}

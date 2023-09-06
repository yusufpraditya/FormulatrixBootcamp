namespace Hewan;

public class Cat : Animal
{
	public new void Move() //  It is recommended to use new keyword to hide method
	{
		Console.WriteLine("Cat is moving..");
	}
}

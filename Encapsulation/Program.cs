using Hewan;
class Program 
{
	static void Main() 
	{
		Cat kucing  = new Cat("Cibi", 12);
		Console.WriteLine(kucing.GetName());
		Console.WriteLine(kucing.GetAge());
	}
}
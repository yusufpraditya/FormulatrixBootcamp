using Project1;
class Program 
{
	static void Main() 
	{
		Console.WriteLine("Keseharian kucing");
		
		Cat kucing1 = new Cat();
		kucing1.Eat();
		kucing1.Meow();
		kucing1.Walk();
		kucing1.Sleep();
	}
}
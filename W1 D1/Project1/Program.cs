using Project1;
class Program 
{
	static void Main() 
	{
		Console.WriteLine("Keseharian kucing");
		
		Cat kucing = new Cat();
		kucing.Eat();
		kucing.Meow();
		kucing.Walk();
		kucing.Sleep();
		
		Console.WriteLine("");
		Console.WriteLine("Keseharian anjing");
		
		Dog anjing = new Dog();
		anjing.Eat();
		anjing.Bark();
		anjing.Walk();
		anjing.Sleep();
	}
}
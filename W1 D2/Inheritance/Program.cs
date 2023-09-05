using Hewan;
class Program 
{
	static void Main() 
	{
		Cat cat = new Cat("Cibi", 1);
		cat.Meow();
		cat.Eat();
		
		Dog dog = new Dog("Gukguk", 2);
		dog.Bark();
		dog.Eat();
	}
}
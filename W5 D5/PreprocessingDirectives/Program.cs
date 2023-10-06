#define DEVELOPMENT
public class Program 
{
	static void Main() 
	{
		#if PRODUCTION
		Console.WriteLine("Production");
		#error "Error"
		#elif DEVELOPMENT
		Console.WriteLine("Development");
		#warning "Warning"
		#elif DEBUG
		Console.WriteLine("Debug");
		#endif
	}
}
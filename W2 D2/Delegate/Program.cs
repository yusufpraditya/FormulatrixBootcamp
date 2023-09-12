public class Program 
{
	// signature: same return type & parameter
	public delegate void MyDelegate(string text);
	static void Main() 
	{
		MyDelegate d = Print;
		
		// two ways of calling or invoking delegate
		d.Invoke("Hello world");
		d("Hello world");
		
	}
	static void Print(string text) 
	{
		Console.WriteLine(text);
	}
}
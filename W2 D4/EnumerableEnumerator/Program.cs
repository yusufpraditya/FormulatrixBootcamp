public class Program 
{
	static void Main() 
	{
		List<string> stringList = new List<string>(){"yusuf", "praditya", "formulatrix"};
		
		IEnumerator<string> enumerator = stringList.GetEnumerator();
		enumerator.MoveNext(); // returns true if can move, returns false if not
		Console.WriteLine(enumerator.Current);
		enumerator.MoveNext(); // praditya
		enumerator.MoveNext(); // formulatrix
		Console.WriteLine(enumerator.MoveNext()); // returns false
		
		enumerator.Reset(); // reset to index -1
		
		while (enumerator.MoveNext()) 
		{
			Console.WriteLine(enumerator.Current);	
		}
	}
}
using ExtensionMethod;

public class Program 
{
	static void Main() 
	{
		string Text = "halo namaku yusuf";
		string NewText = Text.RemoveVowels();
		Console.WriteLine(Text);
		Console.WriteLine(NewText);
		
		Console.WriteLine(MyExtension.RemoveVowels("saat ini aku sedang ikut bootcamp di formulatrix."));
	}
}
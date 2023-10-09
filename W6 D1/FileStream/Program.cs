using System.Text;
using System.IO;

public class Program 
{
	static void Main()
	{
		int offset = 0;
		
		// Write to a file
		string myString = "Hello World";
		using(FileStream fs = new(@"./MyString.txt", FileMode.Create, FileAccess.Write)) {
			byte[] bytes = Encoding.UTF8.GetBytes(myString);
			fs.Write(bytes, offset, bytes.Length - offset);
		}
		
		// Read from a file
		using(FileStream fs = new(@"./MyString2.txt", FileMode.Open, FileAccess.Read)) 
		{
			Console.WriteLine(fs.Length);
			byte[] bytes = new byte[fs.Length];
			fs.Read(bytes, offset, bytes.Length - offset);
			string myString2 = Encoding.UTF8.GetString(bytes);
			Console.WriteLine(myString2);
		}
		
		// FileShare
		using(FileStream fs = new(@"./MyString3.txt", FileMode.Open, FileAccess.Read, FileShare.None)) 
		{
			while (true) 
			{
				
			}
		}
	}
}

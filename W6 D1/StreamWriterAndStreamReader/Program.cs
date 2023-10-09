public class Program 
{
	static void Main() 
	{
		string file1 = @"./Text1.txt";
		string file2 = @"./Text2.txt";
		string file3 = @"./Text3.txt";
		
		using (FileStream fs = new(file1, FileMode.OpenOrCreate, FileAccess.ReadWrite)) 
		{
			using (StreamWriter sw = new(fs)) 
			{
				sw.BaseStream.Position = fs.Seek(0, SeekOrigin.End);
				sw.WriteLine();
				sw.WriteLine("This is new line");
			}
		}
		string[] myString = File.ReadAllLines(file1);
		foreach (var s in myString) 
		{
			Console.WriteLine(s);
		}
		
		// Modify specific line
		int line = 2;
		string newString = "This is new line";
		string[] myString2 = File.ReadAllLines(file2);
		using (FileStream fs = new(file2, FileMode.OpenOrCreate, FileAccess.ReadWrite)) 
		{
			using (StreamWriter sw = new(fs)) 
			{
				myString2[line - 1] = newString;
				foreach (var s in myString2) 
				{
					sw.WriteLine(s);
				}
			}
		}
		
		// Async method
		Task.Run(async () => 
		{
			using (FileStream fs = new(file3, FileMode.OpenOrCreate, FileAccess.ReadWrite)) 
			{
				using (StreamWriter sw = new(fs)) 
				{
					sw.BaseStream.Position = fs.Seek(0, SeekOrigin.End);
					await sw.WriteLineAsync("Hello");
					await sw.WriteLineAsync("Hi");
				}
			}
		}).Wait();
	}
}
public class Program 
{
	static void Main() 
	{
		string text1 = "HeLLo WoRlD";
		Console.WriteLine(text1.ToLower());
		Console.WriteLine(text1.ToUpper());
		
		string text2 = " Hello world ";
		Console.WriteLine(text2.Trim()); // "Hello world"
		Console.WriteLine(text2.PadRight(text2.Length + 5, '!')); // " Hello world !!!!!"
		Console.WriteLine(text2.Replace(' ', '~')); // "~Hello~world~"
		Console.WriteLine(text2.Substring(1, 5)); // "Hello"
		
		// A B C D E F G H I J K L M N O P Q R S T U V W X Y Z [ \ ] ^ _ ` a b c d e f g h i j k l m n o p q r s t u v w x y z
		for (int i = 65; i <= 122; i++) 
		{
			Console.Write((char) i + " ");
		}
	}
}
using System.Text;

namespace ExtensionMethod;

public static class MyExtension
{
	public static string RemoveVowels(this string text) 
	{
		StringBuilder NewString = new();
		text = text.ToLower();
		for (int i = 0; i < text.Length; i++) 
		{
			if (text[i] != 'a' && text[i] != 'i' && text[i] != 'u' && text[i] != 'e' && text[i] != 'o') 
			{
				NewString.Append(text[i]);
			}
		}
		return NewString.ToString();
	} 
}

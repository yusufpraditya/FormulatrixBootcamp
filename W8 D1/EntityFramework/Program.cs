using EntityFramework;
using Microsoft.EntityFrameworkCore;

public class Program 
{
	static void Main() 
	{
		using(Northwind db = new Northwind()) 
		{
			Console.WriteLine($"Name: {db.Database}");
			Console.WriteLine($"Database: {db.Database.ProviderName}");
			Console.WriteLine($"Database: {db.Database.CanConnect()}");
			
			var categories = db.Categories.Where(cat => cat.CategoryId == 1).Include(cat => cat.Products);
			foreach (var cat in categories) 
			{
				Console.WriteLine(cat.CategoryName);
				foreach (var product in cat.Products) 
				{
					Console.WriteLine("  {0}", product.ProductName);
				}
			}
		}
	}
}
using QueueStack;
public class Program 
{
	static void Main() 
	{
		Wardrobe wardrobe = new(2, 5);
		
		wardrobe.TryPutCloth(0, ShirtEnum.Levis);
		wardrobe.TryPutCloth(0, ShirtEnum.Levis);
		wardrobe.TryPutCloth(0, ShirtEnum.Uniqlo);
		wardrobe.TryPutCloth(0, ShirtEnum.Erigo);
		wardrobe.TryPutCloth(0, ShirtEnum.Erigo);
		wardrobe.TryPutCloth(0, ShirtEnum.Uniqlo); // false
		
		wardrobe.TryPutCloth(1, TrousersEnum.Levis);
		wardrobe.TryPutCloth(1, TrousersEnum.Wrangler);
		wardrobe.TryPutCloth(1, TrousersEnum.Jeans);
		wardrobe.TryPutCloth(1, TrousersEnum.Wrangler);
		wardrobe.TryPutCloth(1, TrousersEnum.Jeans);
		wardrobe.TryPutCloth(1, TrousersEnum.Jeans); // false
		
		Console.WriteLine(wardrobe);
		
		// todo: add queue feature
	}
}
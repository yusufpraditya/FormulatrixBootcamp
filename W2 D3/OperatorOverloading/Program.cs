using OperatorOverloading;

public class Program 
{
	static void Main() 
	{
		DragonBall goku = new("Goku", 175, 62, 999);
		DragonBall vegeta = new("Vegeta", 164, 56, 899);
		
		DragonBall fusionedCharacters = goku + vegeta;
		
		DragonBall.PrintCharacterInfo(goku);
		DragonBall.PrintCharacterInfo(vegeta);
		DragonBall.PrintCharacterInfo(fusionedCharacters);
		
	}
}
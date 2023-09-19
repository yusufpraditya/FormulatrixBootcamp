namespace OperatorOverloading;

public class DragonBall
{
	private string? _characterName;
	private int _characterHeight;
	private int _characterWeight;
	private int _characterPower;
	
	public DragonBall(string characterName, int characterHeight, int characterWeight, int characterPower) 
	{
		_characterName = characterName;
		_characterHeight = characterHeight;
		_characterWeight = characterWeight;
		_characterPower = characterPower;
	}
	
	public static DragonBall operator +(DragonBall characterA, DragonBall characterB) 
	{
		Random random = new Random();
		string newName = characterA.CharacterName + characterB.CharacterName;
		int newHeight = random.Next(Math.Min(characterA.CharacterHeight, characterB.CharacterHeight), Math.Max(characterA.CharacterHeight, characterB.CharacterHeight));
		int newWeight = random.Next(Math.Min(characterA.CharacterWeight, characterB.CharacterWeight), Math.Max(characterA.CharacterWeight, characterB.CharacterWeight));
		int newPower = random.Next(Math.Min(characterA.CharacterPower, characterB.CharacterPower), Math.Max(characterA.CharacterPower, characterB.CharacterPower));
		return new DragonBall(newName, newHeight, newWeight, newPower);
	}
	
	public static void PrintCharacterInfo(DragonBall character) 
	{
		Console.WriteLine();
		Console.WriteLine($"Character's name: {character.CharacterName}");
		Console.WriteLine($"Character's height: {character.CharacterHeight}");
		Console.WriteLine($"Character's weight: {character.CharacterWeight}");
		Console.WriteLine($"Character's power: {character.CharacterPower}");
	}
	
	public string? CharacterName 
	{
		get => _characterName;
	}
	
	public int CharacterHeight 
	{
		get => _characterHeight;
		set => _characterHeight = value;
	}
	
	public int CharacterWeight 
	{
		get => _characterWeight;
		set => _characterWeight = value;
	}
	
	public int CharacterPower 
	{
		get => _characterPower;
		set => _characterPower = value;
	}
}

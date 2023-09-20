using System.Text;

namespace QueueStack;

public class Wardrobe
{
	private int _numOfShelves;
	private int _maxShelfCapacity;
	private Stack<Enum>[] _stackOfClothes;
	private List<int> _currentShelfCapacity;
	
	public Wardrobe(int numOfShelves, int maxShelfCapacity) 
	{
		_numOfShelves = numOfShelves;
		_maxShelfCapacity = maxShelfCapacity;
		_stackOfClothes = new Stack<Enum>[numOfShelves];
		for (int i = 0; i < _stackOfClothes.Length; i++) 
		{
			_stackOfClothes[i] = new();
		}
		_currentShelfCapacity = new(new int[_numOfShelves]);
	}
	
	public void PutCloth(int numOfShelf, Enum cloth) 
	{
		// todo
	}
	
	public bool TryPutCloth(int numOfShelf, Enum cloth) 
	{
		if (numOfShelf < 0 || numOfShelf >= _numOfShelves) return false;
		else 
		{
			_currentShelfCapacity[numOfShelf] += 1;
			if (_currentShelfCapacity[numOfShelf] > _maxShelfCapacity) 
			{
				return false;
			}
			_stackOfClothes[numOfShelf].Push(cloth);
			return true;
		}
	}
	
	public bool TryTakeCloth(int numOfShelf) 
	{
		if (numOfShelf < 0 || numOfShelf >= _numOfShelves) return false;
		else 
		{
			_currentShelfCapacity[numOfShelf] -= 1;
			if (_currentShelfCapacity[numOfShelf] < _maxShelfCapacity) 
			{
				return false;
			}
			_stackOfClothes[numOfShelf].Pop();
			return true;
		}
	}
	
	public bool TryPeekCloth(int numOfShelf, out Enum? result) 
	{
		if (numOfShelf < 0 || numOfShelf >= _numOfShelves) {
			result = null;
			return false;
		}
		else 
		{
			result = _stackOfClothes[numOfShelf].Peek();
			return true;
		}
	}
	
	public override string ToString()
	{
		StringBuilder sb = new();
		sb.Append("Current wardrobe contains following clothes:");
		sb.AppendLine();
		foreach (var shelf in _stackOfClothes) 
		{
			IEnumerable<Enum> enumerableStack = shelf;
			sb.Append($"Shelf number: {Array.IndexOf(_stackOfClothes, shelf)} | Number of clothes: {shelf.Count}");
			sb.AppendLine();
			foreach (var item in enumerableStack)
			{
				sb.Append($"{item}");
				sb.AppendLine();
			}
		}
		return sb.ToString();
	}
}
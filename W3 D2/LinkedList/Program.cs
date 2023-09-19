public class Program 
{
	static void Main() 
	{
		LinkedList<int> list = new();
		list.AddLast(2);
		list.AddLast(3);
		list.AddLast(4);
		list.AddFirst(1);
		list.AddLast(6);
		LinkedListNode<int>? node = list.Find(6);
		list.AddBefore(node, 5);
		PrintLinkedList(list, nameof(list));
	}
	
	static void PrintLinkedList(LinkedList<int> list, string varName) 
	{
		Console.Write(varName + ": ");
		foreach (var item in list) 
		{
			Console.Write($"{item} ");
		}
		Console.WriteLine();
	}
}
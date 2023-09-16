namespace EqualityComparison;

public class EqualityClass<T1, T2> 
where T1 : IEquatable<T1>
where T2 : IEquatable<T2>
{
	public bool isEqual(T1 a, T2 b)
	{
		if (a != null && b != null) 
		{
			return a.Equals(b);
		}
		return false;
	}
}

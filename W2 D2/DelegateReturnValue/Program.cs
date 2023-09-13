public delegate decimal Calculator(decimal a, decimal b);
public class Program {
	static void Main() 
	{
		Calculator calc = Add;
		calc += Subtract;
		calc += Multiply;
		calc += Divide;
		
		Delegate[] del = calc.GetInvocationList();
		List<decimal> results = new List<decimal>();
		
		foreach (Calculator d in del) 
		{
			results.Add(d.Invoke(5.1M, 5.1M));
		}
		
		foreach (decimal result in results) 
		{
			Console.WriteLine(result);
		}
	}
	
	static decimal Add(decimal a, decimal b) 
	{
		return a + b;
	}
	
	static decimal Subtract(decimal a, decimal b) 
	{
		return a - b;
	}
	
	static decimal Multiply(decimal a, decimal b) 
	{
		return a * b;
	}
	
	static decimal Divide(decimal a, decimal b) 
	{
		return a / b;
	}
}
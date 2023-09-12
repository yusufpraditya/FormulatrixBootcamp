namespace GenericClass;
public class Car<T1, T2>
where T1 : class
where T2 : struct
{
	private T1 _t1;
	private T2 _t2;
	public Car(T1 t1, T2 t2) 
	{
		_t1 = t1;
		_t2 = t2;
	}
	public T1 GetEngine() 
	{
		return _t1;
	}
	public T2 GetTopSpeed() 
	{
		return _t2;
	}
	public void SetEngine(T1 t1) 
	{
		_t1 = t1;
	}
	public void SetTopSpeed(T2 t2) 
	{
		_t2 = t2;
	}
}

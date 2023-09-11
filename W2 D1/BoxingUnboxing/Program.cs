// boxing -> convert value type to object
int num1 = 123;
object obj1 = num1;

// unboxing -> extract value type from object
object obj2 = 123;
int num2 = (int) obj2;

if (obj2 is ValueType) 
{
	Console.WriteLine("obj2 is ValueType");
} else 
{
	Console.WriteLine("obj2 is not ValueType");
}
// dynamic is not type safety, so it is not recommended.
dynamic variable = 123;
Console.WriteLine($"value: {variable} ({variable.GetType()})");
variable = 123.1f;
Console.WriteLine($"value: {variable} ({variable.GetType()})");
variable = "123abc";
Console.WriteLine($"value: {variable} ({variable.GetType()})");
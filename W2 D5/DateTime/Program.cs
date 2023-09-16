public class Program 
{
	static void Main() 
	{
		
		TimeSpan ts1 = new TimeSpan(1, 30, 30); // (hours, minutes, seconds)
		TimeSpan ts2 = TimeSpan.FromDays(1);
		
		TimeSpan ts3 = ts2.Add(ts1); // 1 day, 1 hour, 30 minutes, and 30 seconds.
		
		var totalHours = ts3.TotalHours;
		var hours = ts3.Hours;
		
		Console.WriteLine(totalHours);
		Console.WriteLine(hours);
		
		DateTime dt1 = new DateTime(2023, 9, 16);
		DateTime dt2 = new DateTime(2023, 9, 16, 12, 0, 0);
		DateTime now = DateTime.Now;
		
		Console.WriteLine(dt1); // 16/09/2023 00:00:00
		Console.WriteLine(dt2); // 16/09/2023 12:00:00
		Console.WriteLine(dt2.AddDays(1)); // 17/09/2023 12:00:00
		Console.WriteLine(now); // current date & time
		
		DateTimeOffset dto1 = new DateTimeOffset(now, TimeSpan.FromHours(7));
		
		Console.WriteLine(dto1);
		
		Console.WriteLine(dt1.ToString("d")); // 16/09/2023
		Console.WriteLine(dt1.ToString("T")); // 00:00:00
		Console.WriteLine(dt1.ToString("D")); // Saturday, 16 September 2023
		Console.WriteLine(dt1.ToString("F")); // Saturday, 16 September 2023 00:00:00
		
		DateTime utc = now.ToUniversalTime();
		Console.WriteLine(utc);
		Console.WriteLine(utc.Kind); // Utc
	}
}
namespace Mobil;

public class Engine
{
	public string? engineType;
	public int horsePower;
	public int torque;
	public Engine(string engineType, int horsePower, int torque) 
	{
		this.engineType = engineType;
		this.horsePower = horsePower;
		this.torque = torque;
	}
}

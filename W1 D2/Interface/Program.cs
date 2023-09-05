using Mobil;

class Program 
{
	static void Main() 
	{
		JetEngine jetEngine = new JetEngine();
		ElectricEngine electricEngine = new ElectricEngine();
		DieselEngine dieselEngine = new DieselEngine();
		
		Car jetCar = new Car(jetEngine);
		Car electricCar = new Car(electricEngine);
		Car dieselCar = new Car(dieselEngine);
		
		jetCar.RunEngine();
		electricCar.RunEngine();
		dieselCar.RunEngine();
	}
}
using System;
namespace CarLotSimulator
{
	public class Car
	{
		public int Year { set; get; }
		public string Make { set; get; }
		public string Model { set; get; }
		public string EngineNoise { set; get; }
		public string HonkNoise { set; get; }
		public bool IsDrivable { get; set; }

		public void MakeEngineNoise(string engineNoise)
		{
			EngineNoise = engineNoise;

			Console.WriteLine($"{Make} {Model} has an engine noise that sounds like {EngineNoise}");
		}

		public void MakeHonkNoise(string honkNoise)
		{
			HonkNoise = honkNoise;



          Console.WriteLine($"{Make} {Model} has an honk noise that sounds like {HonkNoise}.");

        }
	}
}


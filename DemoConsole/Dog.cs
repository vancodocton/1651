using System;

namespace DemoConsole
{
	class Dog : Animal, IJumpable, IFlyable
	{
		public override void Sound()
		{
			Console.WriteLine("Bark!");
		}

		public void Fly()
		{
			Console.WriteLine("In Dream");
		}

		public void Jump()
		{
			Console.WriteLine("By 4 foots");
		}
	}
}

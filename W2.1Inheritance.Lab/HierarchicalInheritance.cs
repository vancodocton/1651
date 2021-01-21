using Farm;

namespace W2._1Inheritance.Lab
{
	internal class HierarchicalInheritance
	{
		public void Run()
		{
			var dog = new StartUp.Dog();
			dog.Eat();
			dog.Bark();

			var cat = new StartUp.Cat();
			cat.Eat();
			cat.Meow();
		}
	}
}

namespace DesignPattern
{
	public sealed class Singleton
	{
		public string Property { get; set; }
		private static Singleton instance;

		public static Singleton GetInstance()
		{
			if (instance == null)
				instance = new Singleton();
			return instance;
		}
		private Singleton()
		{
		}
	}
}

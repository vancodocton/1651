using System;
using System.Collections.Generic;

namespace Lab00ObjectsAndClasses
{
	class Item
	{
		public string Name;
		public double Price;
	}
	class Box
	{
		public Box()
		{
			Item = new Item();
		}
		public int SerialNumber { get; set; }
		public Item Item { get; set; }
		public int ItemQuality { get; set; }
		public double Price
		{
			get
			{
				return Item.Price * ItemQuality;
			}
		}
	}
	class StoreBoxs
	{
		public List<Box> Boxs { get; set; }
		public StoreBoxs()
		{
			Boxs = new List<Box>();
		}
		public void Run()
		{
			string line = Console.ReadLine();

			while (line != "end")
			{
				string[] raw = line.Split();
				Box box = new Box();
				box.SerialNumber = int.Parse(raw[0]);
				box.Item.Name = raw[1];
				box.ItemQuality = int.Parse(raw[2]);
				box.Item.Price = double.Parse(raw[3]);
				Boxs.Add(box);
				line = Console.ReadLine();
			}

			Boxs.Sort(Comparision);
			foreach (var box in Boxs)
			{
				Console.WriteLine(box.SerialNumber);
				Console.WriteLine("-- {0} - ${1:F2}: {2}", box.Item.Name, box.Item.Price, box.ItemQuality);
				Console.WriteLine("-- ${0:F2}", box.Price);
			}
		}
		private static int Comparision(Box box1, Box box2)
		{
			return box2.Price.CompareTo(box1.Price);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Numerics;

namespace Lab00ObjectsAndClasses
{
	// class Program
	// {
	// 	static void Main(string[] args)
	// 	{
	// 		var app = new VehicleCatalogue();

	// 		app.Run();
	// 		Console.ReadKey(true);
	// 	}
	// }
    class BigFactorial
	{
		public void Run()
		{
			int n = int.Parse(Console.ReadLine());

			BigInteger factorial = 1;

			for (int i = 2; i <= n; i++)
			{
				factorial *= i;
			}
			Console.WriteLine(factorial);

		}
	}
    class Song
	{
		public string TypeList { get; set; }
		public string Name { get; set; }
		public string Time { get; set; }
	}
	class SongList
	{
		public int Number { get; set; }
		public List<Song> Songs { get; set; }
		public SongList()
		{
			Songs = new List<Song>();
			Number = 0;
		}
			
		public void Run()
		{
			int Number = int.Parse(Console.ReadLine());

			for (int i = 0; i < Number; i++)
			{
				string[] raw = Console.ReadLine().Split('_');
				AddSong(raw);
			}

			string typeList = Console.ReadLine();
			DisplaySongListType(typeList);
		}
		public void AddSong(string[] raw)
		{
			string type = raw[0];
			string name = raw[1];
			string time = raw[2];

			Song song = new Song
			{
				TypeList = type,
				Name = name,
				Time = time
			};
			Songs.Add(song);
		}
		public void DisplaySongListType(string typeList)
		{
			if (typeList == "all")
			{
				foreach (var song in Songs)
				{
					Console.WriteLine(song.Name);
				}
			}
			else
			{
				foreach (var song in Songs)
				{
					if (song.TypeList == typeList)
						Console.WriteLine(song.Name);
				}
			}
		}
	}
    class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string HomeTown { get; set; }
	}

	class StudentList
	{
		public List<Student> Students { get; set; }

		public StudentList()
		{
			Students = new List<Student>();
		}
		public void Run()
		{
			string[] raw = Console.ReadLine().Split();

			do
			{
				Add(raw);
				raw = Console.ReadLine().Split();
			}
			while (raw[0] != "end");


			string city = Console.ReadLine();
			DisplayStudentInfoFromCity(city);
		}
		public void Add(string[] raw)
		{
			Student student = new Student
			{
				FirstName = raw[0],
				LastName = raw[1],
				Age = int.Parse(raw[2]),
				HomeTown = raw[3]
			};
			Students.Add(student);
		}
		public void DisplayStudentInfoFromCity(string city)
		{
			foreach (var student in Students)
			{
				if (student.HomeTown == city)
				{
					Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
				}
			}
		}
	}
    class StudentList2
	{
		public List<Student> Students { get; set; }

		public StudentList2()
		{
			Students = new List<Student>();
		}
		public void Run()
		{
			string[] raw = Console.ReadLine().Split();

			do
			{
				Add(raw);
				raw = Console.ReadLine().Split();
			}
			while (raw[0] != "end");


			string city = Console.ReadLine();
			DisplayStudentInfoFromCity(city);
		}
		public void Add(string[] raw)
		{
			Student student = new Student
			{
				FirstName = raw[0],
				LastName = raw[1],
				Age = int.Parse(raw[2]),
				HomeTown = raw[3]
			};

			for (int i = 0; i < Students.Count; i++)
			{
				if (student.FirstName == Students[i].FirstName && student.LastName == Students[i].LastName)
				{
					Students[i] = student;
					return;
				}
			}
			Students.Add(student);
		}
		public void DisplayStudentInfoFromCity(string city)
		{
			foreach (var student in Students)
			{
				if (student.HomeTown == city)
				{
					Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
				}
			}
		}
    }
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
    	class Car
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public double HorsePower { get; set; }
	}
	class Truck
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public double Weight { get; set; }
	}
	class Catalog
	{
		public List<Car> Cars { get; set; }
		public List<Truck> Trucks { get; set; }
		public Catalog()
		{
			Cars = new List<Car>();
			Trucks = new List<Truck>();
		}
	}
	class VehicleCatalogue
	{
		public void Run()
		{
            Catalog catalog = new Catalog();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] raw = line.Split('/');

                if (raw[0] == "Car")
                {
                    Car car = new Car
                    {
                        Brand = raw[1],
                        Model = raw[2],
                        HorsePower = double.Parse(raw[3])
                    };
                    catalog.Cars.Add(car);
                }
                else if (raw[0] == "Truck")
                {
                    Truck truck = new Truck()
                    {
                        Brand = raw[1],
                        Model = raw[2],
                        Weight = double.Parse(raw[3])
                    };
                    catalog.Trucks.Add(truck);
                }
                line = Console.ReadLine();
            }

            catalog.Cars.Sort(CmpCar);
            Console.WriteLine("Cars:");
            foreach (var car in catalog.Cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            catalog.Trucks.Sort(CmpTruck);
            Console.WriteLine("Trucks");
            foreach (var truck in catalog.Trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }

        }
        private static int CmpCar(Car car1, Car car2)
        {
            return car1.Brand.CompareTo(car2.Brand);
        }
        private static int CmpTruck(Truck truck1, Truck truck2)
        {
            return truck1.Brand.CompareTo(truck2.Brand);
        }
    }
}

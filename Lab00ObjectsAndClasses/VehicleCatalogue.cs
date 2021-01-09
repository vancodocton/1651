using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab00ObjectsAndClasses
{
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

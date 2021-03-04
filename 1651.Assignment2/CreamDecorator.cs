using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651.Assignment2
{
	class CreamDecorator : MilkTeaDecorator
	{
		private double cost;
		public double Cost { get => cost; private set => cost = value; }

		public CreamDecorator(MilkTea milkTea) : base(milkTea)
		{
			cost = 3000;
		}
		public CreamDecorator(MilkTea milkTea, double cost) : base(milkTea)
		{
			this.cost = cost;
		}

		private string AddCream() => ", add Cream";
		public override double GetCost() => milkTea.GetCost() + cost;
		public override string GetDescription() => milkTea.GetDescription() + AddCream();
	}
}

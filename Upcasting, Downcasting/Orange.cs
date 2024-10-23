using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting
{
	internal class Orange:Fruit
	{
		public decimal VitaminC { get; set; }

		public override void Taste()
		{
			Console.WriteLine("Orange tastes citrusy and refreshing.");
		}
	}
}

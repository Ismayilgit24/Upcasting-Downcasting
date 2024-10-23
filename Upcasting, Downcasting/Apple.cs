using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting
{
	internal class Apple:Fruit
	{
        public decimal VitaminA { get; set; }
		public decimal VitaminB { get; set; }

		public override void Taste()
		{
			Console.WriteLine("Apple tastes sweet and crisp.");
		}
	}
}

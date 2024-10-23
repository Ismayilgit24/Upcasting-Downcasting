using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting
{
	internal class PineApple:Fruit
	{
        public decimal VitaminD { get; set; }
		public decimal VitaminE { get; set; }

		public override void Taste()
		{
			Console.WriteLine("Pineapple tastes tangy and tropical.");
		}

	}
}
